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
        BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        BindingList<Unit> units = new BindingList<Unit>();
        Unit? SelectedUnit
        {
            get => _unitOption.SelectedItem is Unit unit ? unit : null;
            set => _unitOption.SelectedItem = value;
        }
        Product? SelectedProduct
        {
            get => _prodTable.SelectedRows.Count == 0 ? null : (Product)_prodTable.SelectedRows[0].DataBoundItem;
            set
            {
                products[_prodTable.SelectedRows[0].Index] = value;
            }
        }
        RecipeViewModel? SelectedRecipe => _recipe.SelectedItem is RecipeViewModel r ? r : null;
        bool CanSaveProduct => !string.IsNullOrWhiteSpace(_productName.Text.Trim()) && recipes.Count > 0;
        bool CanReset => !string.IsNullOrWhiteSpace(_productName.Text) ||
                         !string.IsNullOrWhiteSpace(_description.Text) ||
                         recipes.Count > 0;

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

            recipes.ListChanged += Recipes_ListChanged;

            SetDataGridColumnBindings();
        }

        void SetDataGridColumnBindings()
        {
            _prodTable.AutoGenerateColumns = false;
            _unitOption.DisplayMember = nameof(Unit.SingularName);

            nameCol.DataPropertyName = nameof(Product.Name);
            barcodeCol.DataPropertyName = nameof(Product.Barcode);
            descCol.DataPropertyName = nameof(Product.Description);
            unitCol.DataPropertyName = nameof(Product.GetUnit);
            ingCol.DataPropertyName = nameof(Product.GetIngredients);
            statusCol.DataPropertyName = nameof(Product.Status);
        }

        private void Recipes_ListChanged(object? sender, ListChangedEventArgs e)
        {
            _cancel.Enabled = CanReset;
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
            _unitOption.DataSource = units;
            _prodTable.DataSource = products;
            _recipe.DataSource = recipes;

            await LoadProducts();

            var u = await _unitGetService.GetAll_Async();

            foreach (var i in u)
                units.Add(i);
            var uAutocomplete = u.Select(x => x.SingularName);
            _unitOption.AutoCompleteCustomSource.AddRange(uAutocomplete.ToArray());

            //_statusOption.LoadArchiveStatus();
        }

        #region crud operations
        async Task<bool> DeleteProduct(Product product)
        {
            if (!DeleteValidationSuccessful(product))
                return false;

            return await _productService.Remove_Async(product);
        }
        async Task<Product?> SaveProductAsync()
        {
            var product = new Product()
            {
                Description = string.IsNullOrWhiteSpace(_description.Text) ? null : _description.Text.Trim(),
                Barcode = string.IsNullOrWhiteSpace(_barcode.Text) ? null : _barcode.Text.Trim(),
                Name = _productName.Text.Trim(),
                Price = 0,
                UnitQty = SelectedUnit,
                Recipes = recipes.Select(r => r.Data)
                .ToList()
            };

            return await _productService.Add_Async(product);
        }
        #endregion

        #region recipe
        private bool RecipeAlreadyPresent(Recipe recipe)
        {
            if (recipes.Count == 0)
                return false;

            return recipes.Any(x => x.Data.Ingredient.Id == recipe.Ingredient.Id);
        }
        private void _addIngredients_Click(object sender, EventArgs e)
        {
            using (var recipeForm = new RecipeForm())
            {
                if (recipeForm.ShowDialog() == DialogResult.OK)
                {
                    var recipe = recipeForm.RecipeDetails;
                    if (!RecipeAlreadyPresent(recipe))
                        recipes.Add(new RecipeViewModel(recipe));
                    else
                    {
                        MessageBox.Show("Ingredient " + recipe.Ingredient.Name + " is already listed.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void _removeRecipe_Click(object sender, EventArgs e)
        {
            if (SelectedRecipe is null)
                return;

            recipes.Remove(SelectedRecipe);
        }
        #endregion

        #region add product
        bool ValidationSuccessful()
        {
            ///product name is empty
            if (string.IsNullOrWhiteSpace(_productName.Text) || recipes.Count == 0)
            {
                MessageBox.Show("Product name and ingredients cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            ///selected unit is not registered
            if (!units.Any(x => string.Equals(x.SingularName, _unitOption.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                OpenUnitForm();
                return false;
            }
            ///user validation
            if (MessageBox.Show("Are you sure you want to save Product?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;

            return true;
        }
        private async void _save_Click(object sender, EventArgs e)
        {
            if (ValidationSuccessful())
            {
                var savedProduct = await SaveProductAsync();

                if (savedProduct is not null)
                {
                    ClearFields();
                    products.Add(savedProduct);
                }
            }
        }
        #endregion

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
        void OpenEditForm()
        {
            if (!EditValidationSuccessful(SelectedProduct))
                return;

            var editProductForm = new EditProductForm(
                SelectedProduct,
                _productService,
                _unitGetService
                );

            var result = editProductForm.OpenFormModal();
            if (result == DialogResult.OK)
            {
                var data = editProductForm.Tag as Product;
                SelectedProduct = data;
                //handle the update of the item editted
            }
        }
        void OpenStockForm()
        {           

            using(var stock = new ViewStockForm(new ProductionHistoryService(), SelectedProduct))
            {
                if(stock.ShowDialog()== DialogResult.OK)
                {

                }
            }
        }
        private void _prodTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            OpenEditForm();
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
                    FilteringFlow.StopUponSatisfaction,
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

        private async void _prodTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            ///if the click column is the delete column or the clicked row is the header
            if (e.ColumnIndex == delCol.Index)
            {
                //if (await DeleteProduct(SelectedProduct!))
                //    products.Remove(SelectedProduct);
                OpenStockForm();

            }
            else if (e.ColumnIndex == editCol.Index)
            {
                OpenEditForm();
            }
            // Debug.WriteLine(e.Clicks);
        }
        private void ClearFields()
        {
            recipes.Clear();
            _productName.Text = _barcode.Text = _description.Text = string.Empty;
        }
        private void fields_TextChanged(object sender, EventArgs e)
        {
            //_save.Enabled = CanSaveProduct;
            _cancel.Enabled = CanReset;
        }
        private void _cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            ClearFields();
        }
        private void _unitOption_Validated(object sender, EventArgs e)
        {
            var u = units.FirstOrDefault(x => string.Equals(x.SingularName, _unitOption.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (SelectedUnit is null)
                OpenUnitForm();
            else
                SelectedUnit = u;
        }
        void OpenUnitForm()
        {
            if (MessageBox.Show("Unit is not recognised. Would you like to register new unit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            var unitForm = new UnitForm(_unitOption.Text.Trim());
            var result = unitForm.OpenFormModal();

            if (result == DialogResult.OK)
            {
                if (unitForm.Tag is Unit u)
                {
                    units.Add(u);
                    _unitOption.SelectedItem = u;
                }
            }
        }

        private async void _archive_retrieve_Click(object sender, EventArgs e)
        {
            var s = SelectedProduct;
            if (s is null) return;

            await _productService.ToggleArchiveAsync(s);

            _archive_retrieve.SetButtonBehavior(s.IsArchived);
            _prodTable.SelectedRows[0].SetRowColor(s.IsArchived);
        }

        //private async void _statusOption_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    await LoadProducts();
        //}

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
            await LoadProducts((int)ArchiveStatus.Active);
        }

        private async void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            await LoadProducts((int)ArchiveStatus.Inactive);
        }

        private async void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            await LoadProducts((int)ArchiveStatus.All);
        }
    }
}
