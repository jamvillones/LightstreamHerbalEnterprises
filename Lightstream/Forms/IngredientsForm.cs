using Lightstream.Models;
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
    public partial class IngredientsForm : Form
    {
        private DbContextFactory factory = new DbContextFactory();
        public string IngredientName => ingredientField.IngredientName;
        public string UnitOfMeasurement => ingredientField.IngredientName;
        public decimal Cost => ingredientField.Cost;
        public bool NewItemCreated { get; private set; }
        public Ingredient CreatedIngredient { get; private set; }

        public IngredientsForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateFields() == false)
            {
                MessageBox.Show("Name and Description cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///open connection
            using (var context = factory.CreateDbContext())
            {
                /// create new ingredient
                var ingredient = new Ingredient()
                {
                    Name = this.IngredientName,
                    Cost = this.Cost,
                    UnitOfMeasurement = this.UnitOfMeasurement
                };

                /// add to the list of ingredients
                context.Ingredients.Add(ingredient);

                /// save changes
                context.SaveChanges();

                CreatedIngredient = ingredient;
            }

            NewItemCreated = true;

            DialogResult = DialogResult.OK;
        }

        private bool ValidateFields()
        {
            return !string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(UnitOfMeasurement);
        }
    }
}
