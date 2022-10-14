using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Services;
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

namespace Lightstream.Usercontrols
{
    public partial class IngredientsPage : Form
    {
        private DbContextFactory factory = new DbContextFactory();

        Ingredient? SelectedIngredient => _ingredientsTable.SelectedRows[0].DataBoundItem as Ingredient;

        public IngredientsPage()
        {
            InitializeComponent();
            _ingredientsTable.AutoGenerateColumns = false;
        }

        private void IngredientUserControl_Load(object sender, EventArgs e)
        {
            _ingredientsTable.DataSource = _ingredients;
            try
            {
                LoadIngredientsFromDbContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var ingredientForm = new Forms.IngredientsForm())
            {
                if (ingredientForm.ShowDialog() == DialogResult.OK)
                    if (ingredientForm.NewItemCreated)
                        _ingredients.Add(ingredientForm.CreatedIngredient);
            }
        }

        bool hasPerformedSearch = false;
        private void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox textbox)
                return;
            string searchTerm = textbox.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
                return;
            if (e.KeyCode == Keys.Enter)
            {
                using (var context = factory.CreateDbContext())
                {
                    var resultingIngredients = SearchHandler.FilterList(
                        context.Ingredients.Include(a => a.UnitMeasurement),
                        filteringConditions: (b) => b.Name.ToLower().Contains(searchTerm.ToLower()))
                        .ToList();

                    if (resultingIngredients.Count == 0)
                    {
                        MessageBox.Show("No entries found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    hasPerformedSearch = true;

                    _ingredients.Clear();
                    foreach (var i in resultingIngredients)
                        _ingredients.Add(i);

                    textbox.SelectAll();
                }
            }
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox textbox) return;

            var text = textbox.Text;

            if (!string.IsNullOrWhiteSpace(text)) return;

            if (!hasPerformedSearch) return;

            LoadIngredientsFromDbContext();
        }

        BindingList<Ingredient> _ingredients = new BindingList<Ingredient>();
        private void LoadIngredientsFromDbContext()
        {
            using (var context = factory.CreateDbContext())
            {
                var ingredients = context.Ingredients.Include(x => x.UnitMeasurement).ToList();

                _ingredients.Clear();
                foreach (var i in ingredients)
                    _ingredients.Add(i);
            }
        }

        private void _delete_Click(object sender, EventArgs e)
        {
            if (_ingredientsTable.RowCount == 0 || 
                MessageBox.Show(
                    "Are you sure you want to remove " + SelectedIngredient?.Name + "?",
                    "", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question) == DialogResult.Cancel
                    )
                return;

            if (DeleteIngredient(out Ingredient? ing))
                if (ing is not null)
                    _ingredients.Remove(ing);
        }

        private bool DeleteIngredient(out Ingredient? ing)
        {
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var i = context.Ingredients.FirstOrDefault(x => x.Id == SelectedIngredient.Id);

                    if (i is not null)
                    {
                        context.Ingredients.Remove(i);
                        context.SaveChanges();
                        Console.WriteLine("removed");
                        ing = SelectedIngredient;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ing = null;
            return false;
        }
    }
}
