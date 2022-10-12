using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                    .Select(a => new { Value = a, Key = a.Name + "-" + a.UnitMeasurement.Name })
                    .ToArray();

                ingredientOption.DataSource = ingredients;
            }
        }

        int ingredientOptValue => ((Ingredient)ingredientOption.SelectedValue).Id;

        private void ingredientOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            unitOption.Text = string.Empty;
            unitOption.Items.Clear();
            using (var context = factory.CreateDbContext())
            {
                var units = context.Units.Where(x => x.Id != ingredientOptValue).ToArray();

                unitOption.Items.AddRange(units);
                unitOption.AutoCompleteCustomSource.AddRange(units.Select(x => x.Name).ToArray());
            }
        }
    }
}
