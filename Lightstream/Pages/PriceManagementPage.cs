using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Services;
using Lightstream.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class PriceManagementPage : Form
    {
        GenericRepository<Product> _productService;

        private BindingList<ProductViewModel> products = new BindingList<ProductViewModel>();
        private BindingList<ProductVariant> variants = new BindingList<ProductVariant>();

        private bool _changesMade = false;
        Product? _selectedProduct;
        public bool ChangesMade
        {
            get { return _changesMade; }
            set
            {
                _changesMade = value;
                button4.Enabled = _changesMade;
            }
        }

        private ProductVariant? selectedVariant
        {
            get
            {
                if (_variantsTable.RowCount == 0)
                    return null;

                return _variantsTable.SelectedRows[0].DataBoundItem as ProductVariant;
            }
            set
            {
                variants[_variantsTable.SelectedRows[0].Index] = value;
            }
        }

        public Product? SelectedProduct
        {
            get => _selectedProduct;

            set
            {
                _selectedProduct = value;

                _selectedProductName.Text = _selectedProduct?.Name;
                variants.Clear();

                if (_selectedProduct is null) return;

                foreach (var v in _selectedProduct.ProductVariants.Where(v => !v.IsArchived))
                    variants.Add(v);
            }
        }

        public PriceManagementPage(GenericRepository<Product> productService)
        {
            InitializeComponent();

            //set the service using DI pattern
            _productService = productService;

            SetupDataGridSettings();
        }

        private async void PriceManagementForm_Load(object sender, EventArgs e)
        {
            await LoadProductsAsync();

            button1.Enabled = products.Count > 0;
        }

        async Task LoadProductsAsync()
        {
            products.Clear();

            var productValues = await _productService.GetAll_Async();

            foreach (var p in productValues.Where(p => !p.IsArchived).OrderBy(x => x.Name))
                products.Add(new ProductViewModel(p));
        }

        void SetupDataGridSettings()
        {
            products = new BindingList<ProductViewModel>();

            _productsTable.AutoGenerateColumns = false;
            _variantsTable.AutoGenerateColumns = false;

            productNumCol.DataPropertyName = nameof(ProductViewModel.Barcode);
            nameCol.DataPropertyName = nameof(ProductViewModel.ProductName);

            prodVariantDescriptionCol.DataPropertyName = nameof(ProductVariant.Description);
            prodVariantPrice.DataPropertyName = nameof(ProductVariant.Price);
            prodVariantCost.DataPropertyName = nameof(ProductVariant.Cost);
            amountCol.DataPropertyName = nameof(ProductVariant.RequiredAmount);
            idCol.DataPropertyName = nameof(ProductVariant.Id);

            _productsTable.DataSource = products;
            _variantsTable.DataSource = variants;
        }

        private void _productsTable_SelectionChanged(object sender, EventArgs e)
        {
            if (sender is DataGridView table)
                if (table.SelectedRows.Count > 0)
                    if (table.SelectedRows[0].DataBoundItem is ProductViewModel p)
                    {
                        SelectedProduct = p.Data;
                        ChangesMade = false;
                    }
        }

        private void _variants_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == delCol.Index)
            {
                _variantsTable.Rows.RemoveAt(e.RowIndex);
                ChangesMade = true;
            }

            if (e.ColumnIndex == editCol.Index)
            {
                var v = OpenVariantForm(selectedVariant);

                if (v is not null)
                {
                    selectedVariant = v;
                    ChangesMade = true;
                }
            }
        }

        bool searchSuccessful = false;
        private async void _search_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox t)
            {
                //var text = t.Text.Trim();
                if (searchSuccessful && string.IsNullOrWhiteSpace(t.Text))
                {
                    searchSuccessful = false;
                    await LoadProductsAsync();
                }
            }
        }

        private async void _search_KeyDown(object sender, KeyEventArgs e)
        {
            var textbox = sender as TextBox;
            //get the text from textbox
            var text = textbox!.Text.Trim();

            //check if the key pressed is enter and then, check if the text is not empty
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(text))
            {
                //get all the products
                var prods = await _productService.GetAll_Async();

                //filter the products by barcode/product number and if not found go next to name contain filter
                var results = SearchHandler.FilterList(
                    prods,
                    FilteringFlags.StopUponSatisfaction,
                    p => string.Equals(p.Barcode, text, StringComparison.OrdinalIgnoreCase),
                    p => p.Name.ToLower().Contains(text.ToLower())
                    );

                // search successful if the results not empty
                searchSuccessful = results.Count() > 0;

                // if NOTHING found, inform the user via propmt and then stop(return)
                if (!searchSuccessful)
                {
                    MessageBox.Show("No products found!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                textbox.SelectAll();
                //reset the list
                products.Clear();

                // repopulate the products with the filtered one
                foreach (var p in results.OrderBy(x => x.Name))
                    products.Add(new ProductViewModel(p));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Add Product Variants?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            if (SelectedProduct is null) return;

            var v = OpenVariantForm();
            if (v is not null)
            {
                v.Product = SelectedProduct;
                variants.Add(v);
                ChangesMade = true;
            }
        }

        ProductVariant? OpenVariantForm(ProductVariant? v = null)
        {

            var f = v is null ?
                new ProductVariantForm() :
                new ProductVariantForm(v);

            using (f)
            {
                if (f.ShowDialog() == DialogResult.OK)
                    return f.Tag as ProductVariant;
            }

            return null;
        }
        //ool changesMade = true;
        private async void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want Save Changes", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

            var prod = SelectedProduct;
            if (prod is null) return;
            prod.ProductVariants = variants.ToList();

            if (ChangesMade)
            {
                var productSaved = await _productService.Update_Async(prod);

                if (productSaved is not null)
                {
                    MessageBox.Show("Product saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChangesMade = false;
                }
            }
        }

        private void _variantsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = _variantsTable.Rows[e.RowIndex];
            if ((int)(row.Cells[0].Value) == 0)
                row.DefaultCellStyle.ForeColor = SystemColors.ControlDarkDark;

        }

        private void _addmarkup_Click(object sender, EventArgs e)
        {
            _Markup markup = new _Markup();
            markup.ShowDialog();
        }

        private void _setDiscount_Click(object sender, EventArgs e)
        {
            _Discount discount = new _Discount();
            discount.ShowDialog();
        }
    }
}
