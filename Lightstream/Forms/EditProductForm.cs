using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class EditProductForm : Form
    {
        private Product product;
        DbContextFactory factory = new DbContextFactory();
        private BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        public EditProductForm(Product product)
        {
            InitializeComponent();
            this.product = product;
        }

        private void addIngBtn_Click(object sender, EventArgs e)
        {
            using (var recimeForm = new RecipeForm())
            {
                if (recimeForm.ShowDialog() == DialogResult.OK)
                {
                    var recipe = recimeForm.RecipeDetails;
                    if (RecipeValidationSuccessfull(recipe.Ingredient.Name) || _recipe.Items.Count == 0)
                        recipes.Add(new RecipeViewModel(recipe));
                }
            }
        }

        private bool RecipeValidationSuccessfull(string incomingIngName)
        {
            return true;

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            using (var context = factory.CreateDbContext())
            {
                var prod = context.Products
                    .Include(x => x.Recipes)
                    .ThenInclude(r=>r.Ingredient)
                    .ThenInclude(r=>r.UnitMeasurement)                 
                    .FirstOrDefault(y => y.Id == product.Id);
                if (prod is null)
                    return;

                _productName.Text = prod.Name;
                _description.Text = prod.Description;

                foreach (var i in prod.Recipes)
                    recipes.Add(new RecipeViewModel(i));
            }
            _recipe.DataSource = recipes;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
