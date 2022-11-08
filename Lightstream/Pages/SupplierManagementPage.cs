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
        Supplier? SelectedUnit
        {
            get => _supplierTable.SelectedRows[0].DataBoundItem as Supplier;
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


        }

        private void _Update_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.ShowDialog();
        }

        async void SupplierManagement_Load(object sender, EventArgs e)
        {
            _supplierTable.DataSource = suppliers;

            await LoadAllSupplier();
        }

        async Task LoadAllSupplier()
        {
            var supplier = await _supplierService.GetAll_Async();

            this.suppliers.Clear();

            foreach (var i in supplier.Where(i=>i.IsArchived is false))
                this.suppliers.Add(i);
        }
        void SetDataGridColumnBindings()
        {
            _supplierTable.AutoGenerateColumns = false;

            snCol.DataPropertyName = nameof(Supplier.Name);
            cpCol.DataPropertyName = nameof(Supplier.ContactPerson);
            cnCol.DataPropertyName = nameof(Supplier.ContactDetails);
            addressCol.DataPropertyName = nameof(Supplier.Address);
            statCol.DataPropertyName = nameof(Supplier.IsArchived);
        }

        private async void _save_Click(object sender, EventArgs e)
        {
            if (!SuccessfullValidation)
            {
                MessageBox.Show("Supplier must not be empty");
                return;
            }

            var addedSupplier = await SaveSupplier();

            if(addedSupplier is not null)            
                suppliers.Add(addedSupplier);            
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

            };
           
            return await _supplierService.Add_Async(supplier);
        }

    }
}


