using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class SupplierManagement : Form
    {
        Supplier? SelectedSupplier
        {
            get => _supplierTable.RowCount == 0 ? null : _supplierTable.SelectedRows[0].DataBoundItem as Supplier;
            set => suppliers[_supplierTable.SelectedRows[0].Index] = value;
        }

        BindingList<Supplier> suppliers = new BindingList<Supplier>();
        private GenericRepository<Supplier> _supplierService;

        public SupplierManagement(GenericRepository<Supplier> supplierService)
        {
            InitializeComponent();
            _supplierService = supplierService;
            SetDataGridColumnBindings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _Add_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;

        }

        private void _Update_Click(object sender, EventArgs e)
        {
            using (var update = new SupplierForm(SelectedSupplier))
            {
                if (update.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        async void SupplierManagement_Load(object sender, EventArgs e)
        {
            _supplierTable.DataSource = suppliers;

            for (int i = 0; i < (int)ArchiveStatus.Count; i++)
                _statusOption.Items.Add((ArchiveStatus)i);

            _statusOption.SelectedIndex = 0;
        }

        async Task LoadAllSupplier()
        {
            var supplier = await _supplierService.GetAll_Async();

            this.suppliers.Clear();

            foreach (var i in supplier)
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
                Address = _address.Text.Trim()
            };

            return await _supplierService.Add_Async(supplier);
        }

        private void _supplierTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedSupplier is null) return;

            _Archive.Enabled = !SelectedSupplier.IsArchived;
            _Retrieve.Enabled = SelectedSupplier.IsArchived;
        }

        private void _supplierTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var supplier = suppliers[e.RowIndex];

            if (sender is DataGridView table)
            {
                table.Rows[e.RowIndex].DefaultCellStyle.BackColor = supplier.IsArchived ? Color.Gray : Color.Green;
            }
        }

        private async void _statusOption_SelectedIndexChanged(object sender, EventArgs e)
        {

            var s = await _supplierService.GetAll_Async();

            var index = (ArchiveStatus)(_statusOption.SelectedIndex);
            switch (index)
            {
                case ArchiveStatus.Active:
                    s = s.Where(x => !x.IsArchived);
                    break;
                case ArchiveStatus.Inactive:
                    s = s.Where(x => x.IsArchived);
                    break;
                default:
                    break;
            }
            suppliers.Clear();

            foreach (var supplier in s)
                suppliers.Add(supplier);

        }

        private async void _Archive_Click(object sender, EventArgs e)
        {
            var s = SelectedSupplier;
            s.IsArchived = true;
            await _supplierService.Update_Async(s);
            ColorChange(s.IsArchived);
        }

        private async void _Retrieve_Click(object sender, EventArgs e)
        {
            var s = SelectedSupplier;
            s.IsArchived = false;
            await _supplierService.Update_Async(s);
            ColorChange(s.IsArchived);
        }
        void ColorChange(bool isArchived)
        {
            _supplierTable.SelectedRows[0].DefaultCellStyle.BackColor = isArchived ? Color.Gray : Color.Green;
        }
    }
}


