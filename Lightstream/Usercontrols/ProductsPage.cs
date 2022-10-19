using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Extensions;
using Lightstream.Forms;
using Lightstream.Services;
using Lightstream.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Usercontrols
{
    public partial class ProductsPage : Form
    {
        DbContextFactory factory = new DbContextFactory();
        BindingList<ProductViewModel> products = new BindingList<ProductViewModel>();
        BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        BindingList<Unit> units = new BindingList<Unit>();
        Unit? SelectedUnit
        {
            get => _unitOption.SelectedItem is Unit unit ? unit : null;
            set => _unitOption.SelectedItem = value;
        }
        ProductViewModel? SelectedProduct => _prodTable.RowCount == 0 ? null : (ProductViewModel)_prodTable.SelectedRows[0].DataBoundItem;
        bool CanSaveProduct => !string.IsNullOrWhiteSpace(_productName.Text.Trim()) && recipes.Count > 0;
        bool CanReset => !string.IsNullOrWhiteSpace(_productName.Text) ||
                         !string.IsNullOrWhiteSpace(_description.Text) ||
                         SelectedUnit is not null ||
                         recipes.Count > 0;
        public ProductsPage()
        {
            InitializeComponent();
            _unitOption.DisplayMember = nameof(Unit.SingularName);
            _prodTable.AutoGenerateColumns = false;
            recipes.ListChanged += Recipes_ListChanged;
            _save.Enabled = _cancel.Enabled = false;
        }

        private void Recipes_ListChanged(object? sender, ListChangedEventArgs e)
        {
            _save.Enabled = CanSaveProduct;
            _cancel.Enabled = CanReset;
            //throw new NotImplementedException();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            //using (var product = new EditProductForm())
            //{
            //    if (product.ShowDialog() == DialogResult.OK)
            //    {
            //        products.Add(new ProductViewModel(new Product() { Id = -1, Name = "Newly Added Product!", Description = "Lerom Ipsum Dolor Amet" }));
            //    }
            //}
        }
        void LoadValues()
        {
            products.Clear();
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var prods = context.Products.Include(x => x.Recipes).Select(p => new ProductViewModel(p)).ToList();
                    products = new BindingList<ProductViewModel>(prods);

                    var u = context.Units.ToList();
                    units = new BindingList<Unit>(u);
                }
            }
            catch { }
        }
        private void ProductsPage_Load(object sender, EventArgs e)
        {
            LoadValues();

            _unitOption.DataSource = units;
            _prodTable.DataSource = products;
            _recipe.DataSource = recipes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProduct(SelectedProduct);
        }

        void EditProduct(ProductViewModel? incomingProduct)
        {
            /////to do
            /////open the form
            /////update            

            //var p = incomingProduct;

            //p.Data.Id = 5487;
            //p.Data.Name = "edit this shit!";
            //p.Data.Description = "Lerom Ipsum Dolor Amet";

            //p.UpdateValues();
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

        private bool RecipeAlreadyPresent(Recipe recipe)
        {
            if (recipes.Count == 0)
                return false;

            return recipes.Any(x => x.Data.Ingredient.Id == recipe.Ingredient.Id);
        }

        private void _save_Click(object sender, EventArgs e)
        {
            if (ValidationSuccessful())
                if (SaveProduct(out Product? savedProduct))
                    if (savedProduct is not null)
                    {
                        ClearFields();
                        products.Add(new ProductViewModel(savedProduct));
                    }
        }

        private void ClearFields()
        {
            recipes.Clear();
            _productName.Text = _description.Text = string.Empty;
        }

        bool ValidationSuccessful()
        {
            ///product name is empty
            if (string.IsNullOrWhiteSpace(_productName.Text))
            {
                MessageBox.Show("Product name cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        bool SaveProduct(out Product? savedProduct)
        {
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var newProduct = new Product()
                    {
                        Description = _description.Text.Trim(),
                        Name = _productName.Text.Trim(),
                        Price = 0,
                        UnitQty = context.Units.FirstOrDefault(x => x.Id == SelectedUnit.Id) ?? new Unit() { SingularName = _unitOption.Text.Trim() }
                    };

                    foreach (var i in recipes)
                        newProduct.Recipes.Add(new Recipe()
                        {
                            Id = i.Data.Id,
                            Qty = i.Data.Qty,
                            ConversionId = i.Data.Conversion?.Id,
                            IngredientId = i.Data.Ingredient.Id,
                        });

                    context.Products.Add(newProduct);
                    context.SaveChanges();

                    savedProduct = newProduct;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                savedProduct = null;
                return false;
            }
            return true;
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;
            ClearFields();
        }

        #region delete product
        private void _deleteProduct_Click(object sender, EventArgs e)
        {
            if (DeleteProduct(SelectedProduct.Data))
                products.Remove(SelectedProduct);
        }

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
        bool DeleteProduct(Product product)
        {
            if (!DeleteValidationSuccessful(SelectedProduct.Data))
                return false;

            using (var context = factory.CreateDbContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return true;
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

            var result = new EditProductForm(SelectedProduct.Data).OpenFormModal();
            if (result == DialogResult.OK)
            {
                //handle the update of the item editted
            }
        }
        #endregion

        #region search
        bool searchDone = false;
        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox t)
            {
                var text = t.Text.Trim();
                if (string.IsNullOrWhiteSpace(text) && searchDone)
                {
                    LoadValues();
                    searchDone = false;
                }
            }
        }

        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox t && e.KeyCode == Keys.Enter)
            {
                var text = t.Text.Trim();

                if (string.IsNullOrWhiteSpace(text))
                    return;

                using (var context = factory.CreateDbContext())
                {
                    var filtered = SearchHandler.FilterList(context.Products, filteringConditions: x => x.Name.ToLower().Contains(text.ToLower()));
                    searchDone = filtered.Count() != 0;

                    if (!searchDone)
                    {
                        MessageBox.Show("No products found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    searchDone = true;
                    t.SelectAll();
                    products.Clear();
                    foreach (var i in filtered)
                        products.Add(new ProductViewModel(i));
                }
            }
        }
        #endregion

        private void _prodTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            ///if the click column is the delete column or the clicked row is the header
            if (e.ColumnIndex == delCol.Index)
            {
                if (DeleteProduct(SelectedProduct.Data))
                    products.Remove(SelectedProduct);

            }
            else if (e.ColumnIndex == editCol.Index)
            {
                OpenEditForm();
            }
        }

        private void fields_TextChanged(object sender, EventArgs e)
        {
            _save.Enabled = CanSaveProduct;
            _cancel.Enabled = CanReset;
        }

        private void _unitOption_Validated(object sender, EventArgs e)
        {
            var u = units.FirstOrDefault(x => string.Equals(x.SingularName, _unitOption.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (u is null)
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
