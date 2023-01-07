using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
using Lightstream.Forms;
using Lightstream.Services;
using Lightstream.ViewModels;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel;
using System.Data;

namespace Lightstream.Usercontrols
{
    public partial class ProductsPage : Form
    {
        BindingList<Product> products = new();

        Product? SelectedProduct
        {
            get => _prodTable.SelectedRows.Count == 0 ? null : (Product)_prodTable.SelectedRows[0].DataBoundItem;
            set
            {
                products[_prodTable.SelectedRows[0].Index] = value;
            }
        }

        GenericRepository<Product> _productService;
        GenericRepository<Unit> _unitGetService;

        public ProductsPage(
            GenericRepository<Product> productService,
            GenericRepository<Unit> unitService
            )
        {
            InitializeComponent();

            _productService = productService;
            _unitGetService = unitService;

            SetDataGridColumnBindings();
        }

        void SetDataGridColumnBindings()
        {
            _prodTable.AutoGenerateColumns = false;

            nameCol.DataPropertyName = nameof(Product.Name);
            barcodeCol.DataPropertyName = nameof(Product.Barcode);
            descCol.DataPropertyName = nameof(Product.Description);
            unitCol.DataPropertyName = nameof(Product.GetUnit);
            ingCol.DataPropertyName = nameof(Product.GetIngredients);
            statusCol.DataPropertyName = nameof(Product.Status);
        }

        int selectedStatus => radioButton1.Checked ? (int)ArchiveStatus.Active : radioButton2.Checked ? (int)ArchiveStatus.Inactive : (int)ArchiveStatus.All;
        async Task LoadProducts()
        {
            var prods = await _productService.GetAll_Async();
            var filtered = prods.FilterByStatus(selectedStatus);

            products.Clear();
            foreach (var i in filtered.OrderBy(x => x.Name))
                products.Add(i);
        }

        async Task LoadProducts(int index)
        {
            var prods = await _productService.GetAll_Async();
            var filtered = prods.FilterByStatus(index);

            products.Clear();
            foreach (var i in filtered.OrderBy(x => x.Name))
                products.Add(i);
        }

        private async void ProductsPage_Load(object sender, EventArgs e)
        {
            _prodTable.DataSource = products;

            await LoadProducts();

            var u = await _unitGetService.GetAll_Async();
        }

        async Task<bool> DeleteProduct(Product product)
        {
            if (!DeleteValidationSuccessful(product))
                return false;

            return await _productService.Remove_Async(product);
        }

        #region edit product
        bool EditValidationSuccessful(Product product)
        {
            return (SelectedProduct is not null &&
                MessageBox.Show(
                    "Are you sure you want to edit " + product.Name + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    ) == DialogResult.OK);
        }
        void OpenProductForm()
        {
            if (!EditValidationSuccessful(SelectedProduct))
                return;

            var editProductForm = new ProductForm(
                _productService,
                _unitGetService,
                SelectedProduct
                );

            var result = editProductForm.OpenFormModal();
            if (result == DialogResult.OK)
            {
                var data = editProductForm.Tag as Product;
                SelectedProduct = data;
            }
        }

        void OpenStockForm()
        {
            using (var stock = new ViewStockForm(new ProductionHistoryService(), SelectedProduct))
            {
                if (stock.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void _prodTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            OpenStockForm();
        }
        #endregion

        #region delete product
        bool DeleteValidationSuccessful(Product product)
        {
            return (SelectedProduct is not null &&
                MessageBox.Show(
                    "Are you sure you want to delete " + product.Name + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    ) == DialogResult.OK);
        }
        private async void _deleteProduct_Click(object sender, EventArgs e)
        {
            if (await DeleteProduct(SelectedProduct))
                products.Remove(SelectedProduct);
        }
        #endregion

        #region search
        bool searchSuccessful = false;
        private async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox t)
            {
                var text = t.Text.Trim();
                if (string.IsNullOrWhiteSpace(text) && searchSuccessful)
                {
                    await LoadProducts();
                    searchSuccessful = false;
                }
            }
        }

        private async void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox t && e.KeyCode == Keys.Enter)
            {
                var text = t.Text.Trim();

                if (string.IsNullOrWhiteSpace(text))
                    return;
                var products = await _productService.GetAll_Async();

                var filtered = SearchHandler.FilterList(
                    products,
                    FilteringFlags.StopUponSatisfaction,
                    x => string.Equals(x.Barcode, text, StringComparison.CurrentCultureIgnoreCase),
                    x => x.Name.ToLower().Contains(text.ToLower())
                    );

                searchSuccessful = filtered.Count() != 0;

                if (!searchSuccessful)
                {
                    MessageBox.Show("No products found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                t.SelectAll();

                this.products.Clear();

                foreach (var i in filtered)
                    this.products.Add(i);
            }
        }
        #endregion

        private void _prodTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            ///if the click column is the delete column or the clicked row is the header
            if (e.ColumnIndex == delCol.Index)
                OpenStockForm();

            else if (e.ColumnIndex == editCol.Index)
                OpenProductForm();
        }

        private async void _archive_retrieve_Click(object sender, EventArgs e)
        {

            var s = SelectedProduct;
            if (s is null) return;

            await _productService.ToggleArchiveAsync(s);


            _archive_retrieve.SetButtonBehavior(s.IsArchived);
            _prodTable.SelectedRows[0].SetRowColor(s.IsArchived);

            if (StatusDoNotMatch(s.IsArchived, CurrentSelectedStatus))
                products.Remove(s);
        }

        private bool StatusDoNotMatch(bool archiveStatus, ArchiveStatus SelectedStatus)
        {
            return archiveStatus && SelectedStatus == ArchiveStatus.Active || !archiveStatus && SelectedStatus == ArchiveStatus.Inactive;
        }

        private ArchiveStatus CurrentSelectedStatus = ArchiveStatus.Active;

        private async Task ChangeSelectionStatus(ArchiveStatus nextStatus)
        {
            CurrentSelectedStatus = nextStatus;

            await LoadProducts((int)nextStatus);

            //if(CurrentSelectedStatus == ArchiveStatus.Active)
        }

        private void _prodTable_SelectionChanged(object sender, EventArgs e)
        {
            var su = SelectedProduct;
            if (su is null) return;
            _archive_retrieve.SetButtonBehavior(su.IsArchived);
        }

        private void _prodTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var row = _prodTable.Rows[e.RowIndex];
            row.SetRowColor(products[e.RowIndex].IsArchived);
        }

        private async void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //await LoadProducts((int)ArchiveStatus.Active);
            await ChangeSelectionStatus(ArchiveStatus.Active);
        }

        private async void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //await LoadProducts((int)ArchiveStatus.Inactive);
            await ChangeSelectionStatus(ArchiveStatus.Inactive);
        }

        private async void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //await LoadProducts((int)ArchiveStatus.All);
            await ChangeSelectionStatus(ArchiveStatus.All);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editProductForm = new ProductForm(
               _productService,
               _unitGetService
               );

            var result = editProductForm.OpenFormModal();
            if (result == DialogResult.OK)
                if (editProductForm.Tag is Product newProduct)
                    products.Add(newProduct);
        }
    }
}
