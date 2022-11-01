﻿using Lightstream.DataAccess.Models;
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
    public partial class PriceManagementForm : Form
    {
        GenericRepository<Product> _productService;

        private BindingList<ProductViewModel> products;
        private BindingList<ProductVariant> variants;

        Product _selectedProduct;
        public Product SelectedProduct
        {
            get => _selectedProduct;

            set
            {
                _selectedProduct = value;

                _selectedProductName.Text = _selectedProduct.Name;
                variants.Clear();

                foreach (var v in _selectedProduct.ProductVariants.Where(v => !v.Archived))
                    variants.Add(v);
            }
        }

        public PriceManagementForm(GenericRepository<Product> productService)
        {
            InitializeComponent();

            //set the service using DI pattern
            _productService = productService;

            products = new BindingList<ProductViewModel>();
            variants = new BindingList<ProductVariant>();
        }

        private async void PriceManagementForm_Load(object sender, EventArgs e)
        {
            SetupDataGridSettings();

            await LoadProductsAsync();
        }

        async Task LoadProductsAsync()
        {
            products.Clear();

            var productValues = await _productService.GetAll_Async();

            foreach (var p in productValues) products.Add(new ProductViewModel(p));
        }

        void SetupDataGridSettings()
        {
            products = new BindingList<ProductViewModel>();

            //we manually set the values with bindings thats why we set it to false
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
                if (table.SelectedRows.Count > 0)
                    if (table.SelectedRows[0].DataBoundItem is ProductViewModel p)
                        SelectedProduct = p.Data;
        }

        private void _variants_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex != delCol.Index)
                return;

            _variantsTable.Rows.RemoveAt(e.RowIndex);
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
                    FilteringFlow.StopUponSatisfaction,
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
                foreach (var p in results)
                    products.Add(new ProductViewModel(p));
            }
        }
    }
}
