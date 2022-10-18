using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
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
        ProductViewModel? SelectedProduct => _prodTable.RowCount == 0 ? null : (ProductViewModel)_prodTable.SelectedRows[0].DataBoundItem;

        bool CanSaveProduct => !string.IsNullOrWhiteSpace(_productName.Text.Trim()) && recipes.Count > 0;
        bool CanReset => !string.IsNullOrWhiteSpace(_productName.Text) ||
                         !string.IsNullOrWhiteSpace(_description.Text) ||
                         !string.IsNullOrWhiteSpace(textBox2.Text) ||
                         recipes.Count > 0;
        public ProductsPage()
        {
            InitializeComponent();
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
        void LoadProducts()
        {
            products.Clear();
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var prods = context.Products.Include(x => x.Recipes);
                    foreach (var i in prods)
                        products.Add(new ProductViewModel(i));
                }
            }
            catch { }
        }
        private void ProductsPage_Load(object sender, EventArgs e)
        {
            LoadProducts();

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
            if (string.IsNullOrWhiteSpace(_productName.Text))
            {
                MessageBox.Show("Product name cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
                        Price = 0
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

            using (var edit = new EditProductForm(SelectedProduct.Data))
            {
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    //handle changes
                }
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
                    LoadProducts();
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
    }
}
