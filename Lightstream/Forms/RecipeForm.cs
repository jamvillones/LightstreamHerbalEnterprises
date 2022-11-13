using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class RecipeForm : Form
    {
        private DbContextFactory factory = new DbContextFactory();
        public RecipeForm()
        {
            InitializeComponent();
        }

        private void RecipeForm_Load(object sender, EventArgs e)
        {
            using (var context = factory.CreateDbContext())
            {
                var ingredients = context.Ingredients.Include(x => x.UnitMeasurement)
                    .Select(a => new { Value = a, Key = a.Name + " in " + a.UnitMeasurement.SingularName })
                    .ToArray();

                //AvailableUnits = context.Units.ToList();               

                ingredientOption.SelectedIndexChanged += ingredientOption_SelectedIndexChanged;                
                ingredientOption.DataSource = ingredients;
            }
        }

        private void ingredientOption_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        bool Save()
        {
            RecipeDetails = new Recipe()
            {
                Qty = qty.Value,
                Ingredient = (Ingredient)ingredientOption.SelectedValue
            };

            DialogResult = DialogResult.OK;

            return true;
        }

        public Recipe RecipeDetails { get; private set; }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ingredientOption.SelectedValue is Ingredient ing)
            {
                //bool isFound = IsConversionAvailable(fromUnit, ing.UnitMeasurement, out selectedConversion);
         
               Save();
                
            }
        }

        private void addConversionBtn_Click(object sender, EventArgs e)
        {
            //OpenConversionCreation();
        }
    }

}
