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
        private BindingList<ProductVariant> variants;

        Product _selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return _selectedProduct;
            }
            set
            {
                _selectedProduct = value;
                variants.Clear();
                foreach (var v in _selectedProduct.ProductVariants.Where(v => !v.Archived))
                    variants.Add(v);
            }
        }
        public PriceManagementForm(GenericRepository<Product> productService)
        {
            InitializeComponent();
            //set the service using di pattern
            _productService = productService;
            products = new BindingList<ProductViewModel>();
            variants = new BindingList<ProductVariant>();
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
            _variantsTable.AutoGenerateColumns = false;

            productNumCol.DataPropertyName = nameof(ProductViewModel.Barcode);
            nameCol.DataPropertyName = nameof(ProductViewModel.ProductName);

            prodVariantDescriptionCol.DataPropertyName = nameof(ProductVariant.Description);
            prodVariantPrice.DataPropertyName = nameof(ProductVariant.Price);
            prodVariantCost.DataPropertyName = nameof(ProductVariant.Cost);

            _productsTable.DataSource = products;
            _variantsTable.DataSource = variants;
        }

        private void _productsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView table)
            {
                if (table.SelectedRows[0].DataBoundItem is ProductViewModel p)
                    SelectedProduct = p.Data;
            }
        }

        private async void _variants_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (_variantsTable.SelectedRows[0].DataBoundItem is ProductVariant pv)
            {
                var selectedVariant = pv;

                selectedVariant.Archived = true;
            }
        }
    }
}
