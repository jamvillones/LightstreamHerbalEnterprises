using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.ViewModels;
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
    public partial class PriceManagementForm : Form
    {
        GenericRepository<Product> _productService;

        private BindingList<ProductViewModel> products;
        public PriceManagementForm(GenericRepository<Product> productService)
        {
            InitializeComponent();
            //set the service using di pattern
            _productService = productService;
        }

        private void _PMTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void PriceManagementForm_Load(object sender, EventArgs e)
        {
            SetupDataGridSettings();

            var productValues = await _productService.GetAll_Async();

            foreach (var p in productValues)
                products.Add(new ProductViewModel(p));
        }

        void SetupDataGridSettings()
        {
            products = new BindingList<ProductViewModel>();
            //we manually set the values with bindings
            _productsTable.AutoGenerateColumns = false;

            productNumCol.DataPropertyName = nameof(ProductViewModel.Barcode);
            nameCol.DataPropertyName = nameof(ProductViewModel.ProductName);
            //costCol.DataPropertyName = nameof(ProductVie)

            _productsTable.DataSource = products;
        }
    }
}
