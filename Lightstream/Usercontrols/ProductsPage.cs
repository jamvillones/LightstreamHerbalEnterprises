using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Forms;
using Lightstream.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
        public ProductsPage()
        {
            InitializeComponent();
            _prodTable.AutoGenerateColumns = false;
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var product = new ProductForm())
            {
                if (product.ShowDialog() == DialogResult.OK)
                {
                    products.Add(new ProductViewModel(new Product() { Id = -1, Name = "Newly Added Product!", Description = "Lerom Ipsum Dolor Amet" }));
                }
            }
        }

        private void ProductsPage_Load(object sender, EventArgs e)
        {
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
            //for (int i = 0; i < 6; i++)
            //{
            //    products.Add(new ProductViewModel(new Product() { Id = i, Name = "sample product name", Description = "lerom ipsum" }));
            //}
            _prodTable.DataSource = products;
            _recipe.DataSource = recipes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditProduct(SelectedProduct);
        }

        void EditProduct(ProductViewModel? incomingProduct)
        {
            ///to do
            ///open the form
            ///update            

            var p = incomingProduct;

            p.Data.Id = 5487;
            p.Data.Name = "edit this shit!";
            p.Data.Description = "Lerom Ipsum Dolor Amet";

            p.UpdateValues();
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
                        Clear();
                        products.Add(new ProductViewModel(savedProduct));
                    }
        }

        private void Clear()
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
            Clear();
        }

        private void _deleteProduct_Click(object sender, EventArgs e)
        {
            if (SelectedProduct is null ||
                MessageBox.Show(
                    "Are you sure you want to delete " + SelectedProduct.ProductName + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                    ) == DialogResult.Cancel)
                return;

            if (DeleteProduct(SelectedProduct.Data))
                products.Remove(SelectedProduct);
        }

        bool DeleteProduct(Product product)
        {
            using (var context = factory.CreateDbContext())
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
            return true;
        }
    }
}
