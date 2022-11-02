using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
using Lightstream.Forms;
using Lightstream.Services;
using Lightstream.ViewModels;
using System.ComponentModel;
using System.Data;

namespace Lightstream.Usercontrols
{
    public partial class ProductsPage : Form
    {
        BindingList<ProductViewModel> products = new BindingList<ProductViewModel>();
        BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        BindingList<Unit> units = new BindingList<Unit>();
        Unit? SelectedUnit
        {
            get => _unitOption.SelectedItem is Unit unit ? unit : null;
            set => _unitOption.SelectedItem = value;
        }
        ProductViewModel? SelectedProduct => _prodTable.RowCount == 0 ? null : (ProductViewModel)_prodTable.SelectedRows[0].DataBoundItem;
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
            unitCol.DataPropertyName = nameof(ProductViewModel.Unit);
            ingCol.DataPropertyName = nameof(ProductViewModel.Ingredients);
            barcodeCol.DataPropertyName = nameof(ProductViewModel.Barcode);
        }

        private void Recipes_ListChanged(object? sender, ListChangedEventArgs e)
        {
            _cancel.Enabled = CanReset;
        }

        async Task LoadProducts()
        {
            products.Clear();

            var prods = await _productService.GetAll_Async();

            foreach (var i in prods)
                products.Add(new ProductViewModel(i));
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
                Recipes = recipes.Select(r =>
                    new Recipe()
                    {
                        Ingredient = r.Data.Ingredient,
                        Qty = r.Data.Qty,
                        Conversion = r.Data.Conversion
                    }
                ).ToList()
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
                    products.Add(new ProductViewModel(savedProduct));
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
            if (!EditValidationSuccessful(SelectedProduct.Data))
                return;

            var editProductForm = new EditProductForm(
                SelectedProduct.Data,
                _productService,
                _unitGetService
                );

            var result = editProductForm.OpenFormModal();
            if (result == DialogResult.OK)
            {
                var data = editProductForm.Tag as Product;
                SelectedProduct.Data = data;
                //handle the update of the item editted
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
            if (await DeleteProduct(SelectedProduct.Data))
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
                    this.products.Add(new ProductViewModel(i));
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
                if (await DeleteProduct(SelectedProduct.Data))
                    products.Remove(SelectedProduct);

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
                var unit = unitForm.ResultingUnit;
                units.Add(unit);
                _unitOption.SelectedItem = unit;
            }

        }
    }
}
