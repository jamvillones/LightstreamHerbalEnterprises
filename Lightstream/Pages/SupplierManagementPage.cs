using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
using Lightstream.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lightstream.Extensions;

namespace Lightstream.Forms
{
    public partial class SupplierManagement : Form
    {
        Supplier? SelectedSupplier
        {
            get => _supplierTable.RowCount == 0 ? null : _supplierTable.SelectedRows[0].DataBoundItem as Supplier;
            set => suppliers[_supplierTable.SelectedRows[0].Index] = value!;
        }

        BindingList<Supplier> suppliers = new BindingList<Supplier>();
        private GenericRepository<Supplier> _supplierService;

        public SupplierManagement(GenericRepository<Supplier> supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            SetDataGridColumnBindings();
        }

        private void _Add_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
        }

        private void _Update_Click(object sender, EventArgs e)
        {
            if (suppliers.Count == 0) return;

            using (var update = new SupplierForm(SelectedSupplier!) { SupplierService = _supplierService })
            {
                if (update.ShowDialog() == DialogResult.OK)
                    if (update.Tag is Supplier s)
                        SelectedSupplier = s;
            }
        }

        void SupplierManagement_Load(object sender, EventArgs e)
        {
            _supplierTable.DataSource = suppliers;

            _statusOption.LoadArchiveStatus();
        }

        async Task LoadAllSupplier()
        {
            var supplier = await _supplierService.GetAll_Async();

            supplier = supplier.FilterByStatus(_statusOption.SelectedIndex);

            this.suppliers.Clear();
            foreach (var i in supplier.OrderBy(x => x.Name))
                this.suppliers.Add(i);
        }
        void SetDataGridColumnBindings()
        {
            _supplierTable.AutoGenerateColumns = false;

            snCol.DataPropertyName = nameof(Supplier.Name);
            cpCol.DataPropertyName = nameof(Supplier.ContactPerson);
            cnCol.DataPropertyName = nameof(Supplier.ContactDetails);
            addressCol.DataPropertyName = nameof(Supplier.Address);
            statCol.DataPropertyName = nameof(Supplier.Status);
        }

        private async void _save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Save Supplier?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (!SuccessfullValidation)
            {
                MessageBox.Show("Supplier must not be empty");
                return;
            }

            var addedSupplier = await SaveSupplier();

            if (addedSupplier is not null)
            {
                suppliers.Add(addedSupplier);
                panel1.Enabled = false;
                ClearFields();
            }
        }

        void ClearFields()
        {
            _supplierName.Clear();
            _contactperson.Clear();
            _contactnumber.Clear();
            _address.Clear();
        }

        bool SuccessfullValidation => !string.IsNullOrWhiteSpace(_supplierName.Text);

        async Task<Supplier?> SaveSupplier()
        {
            var supplier = new Supplier()
            {
                Name = _supplierName.Text.Trim(),
                ContactDetails = _contactnumber.Text.Trim(),
                ContactPerson = _contactperson.Text.Trim(),
                Address = _address.Text.Trim(),

                SupplierToIngredients = new List<SupplierToIngredient>()
            };

            return await _supplierService.Add_Async(supplier);
        }

        private void _supplierTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedSupplier is null) return;

            _Archive.SetButtonBehavior(SelectedSupplier.IsArchived);
        }

        private void _supplierTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var supplier = suppliers[e.RowIndex];

            if (sender is DataGridView table)
                table.Rows[e.RowIndex].SetRowColor(supplier.IsArchived);
        }

        private async void _statusOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAllSupplier();
        }

        private async void ArchiveRetrieve_Click(object sender, EventArgs e)
        {
            var s = SelectedSupplier;
            if (s is null) return;


            await _supplierService.ToggleArchiveAsync(s);
            _supplierTable.SelectedRows[0].SetRowColor(s.IsArchived);
            _Archive.SetButtonBehavior(s.IsArchived);
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        bool searchFound = false;

        private async void _search_TextChanged(object sender, EventArgs e)
        {
            if (!searchFound) return;
            var text = sender as TextBox;
            if (!string.IsNullOrWhiteSpace(text.Text)) return;

            await LoadAllSupplier();
            searchFound = false;
        }

        private async void _search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var text = (sender as TextBox)!.Text.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(text))
                    return;

                var items = await _supplierService.GetAll_Async();

                items = SearchHandler.FilterList(
                   items,
                   FilteringFlags.StopUponSatisfaction,
                   x => x.Name.ToLower().Contains(text)
                   );

                searchFound = items.Count() > 0;
                if (!searchFound)
                {
                    MessageBox.Show("No supplier found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.suppliers.Clear();
                foreach (var u in items.OrderBy(x => x.Name))
                {
                    this.suppliers.Add(u);
                }
            }
        }

        private void _supplierTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != editCol.Index) return;

            if (suppliers.Count == 0) return;

            using (var update = new SupplierForm(SelectedSupplier!) { SupplierService = _supplierService })
            {
                if (update.ShowDialog() == DialogResult.OK)
                    if (update.Tag is Supplier s)
                        SelectedSupplier = s;
            }
        }
    }
}


