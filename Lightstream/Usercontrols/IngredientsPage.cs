using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lightstream.Usercontrols
{
    internal sealed partial class IngredientsPage : Form
    {
        DbContextFactory factory = new DbContextFactory();
        Ingredient? SelectedIngredient => _ingredientsTable.SelectedRows[0].DataBoundItem as Ingredient;
        BindingList<Ingredient> ingredients = new BindingList<Ingredient>();
        bool searchFound = false;
        public IngredientsPage()
        {
            InitializeComponent();
            _ingredientsTable.AutoGenerateColumns = false;
        }
        void IngredientUserControl_Load(object sender, EventArgs e)
        {
            _ingredientsTable.DataSource = ingredients;
            try
            {
                LoadAllIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var ingredientForm = new Forms.IngredientsForm())
            {
                if (ingredientForm.ShowDialog() == DialogResult.OK)
                    if (ingredientForm.NewItemCreated)
                        ingredients.Add(ingredientForm.CreatedIngredient);
            }
        }
        void searchTxt_KeyDown(object sender, KeyEventArgs e)
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

                    searchFound = true;

                    ingredients.Clear();
                    foreach (var i in resultingIngredients)
                        ingredients.Add(i);

                    textbox.SelectAll();
                }
            }
        }
        void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox textbox) return;

            var text = textbox.Text;

            if (!string.IsNullOrWhiteSpace(text)) return;

            if (!searchFound) return;

            LoadAllIngredients();
        }
        void LoadAllIngredients()
        {
            using (var context = factory.CreateDbContext())
            {
                var ingredients = context.Ingredients.Include(x => x.UnitMeasurement).ToList();

                this.ingredients.Clear();
                foreach (var i in ingredients)
                    this.ingredients.Add(i);
            }
        }
        void _delete_Click(object sender, EventArgs e)
        {
            if (_ingredientsTable.RowCount == 0 ||
                MessageBox.Show(
                    "Are you sure you want to remove " + SelectedIngredient?.Name + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.Cancel
                    )
                return;

            if (SelectedIngredient is not null)
                if (DeleteIngredient(SelectedIngredient))
                    ingredients.Remove(SelectedIngredient);
        }
        bool DeleteIngredient(Ingredient? ing)
        {
            if (ing is null)
                return false;

            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var i = context.Ingredients.FirstOrDefault(x => x.Id == ing.Id);

                    if (i is not null)
                    {
                        context.Ingredients.Remove(i);
                        context.SaveChanges();
                        Console.WriteLine("removed");

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        void _ingredientsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left||
                e.RowIndex == -1 ||
                e.ColumnIndex != deleteBtnCol.Index ||
                  MessageBox.Show(
                    "Are you sure you want to remove " + SelectedIngredient?.Name + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.Cancel
                    )
                return;

            if (SelectedIngredient is not null)
                if (DeleteIngredient(SelectedIngredient))
                    ingredients.Remove(SelectedIngredient);
        }
    }
}
