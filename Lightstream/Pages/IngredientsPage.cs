using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Services;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Lightstream.Usercontrols
{
    internal sealed partial class IngredientsPage : Form
    {
        DbContextFactory factory = new DbContextFactory();
        Ingredient? SelectedIngredient
        {
            get => _ingredientsTable.SelectedRows[0].DataBoundItem as Ingredient;

            set
            {
                ingredients[_ingredientsTable.SelectedRows[0].Index] = value;
            }
        }
        BindingList<Ingredient> ingredients = new BindingList<Ingredient>();
        bool searchSuccessful = false;

        private GenericRepository<Ingredient> _ingredientService;
        public IngredientsPage(GenericRepository<Ingredient> ingService)
        {
            InitializeComponent();

            _ingredientService = ingService;
            _ingredientsTable.AutoGenerateColumns = false;
        }
        async void IngredientUserControl_Load(object sender, EventArgs e)
        {
            _ingredientsTable.DataSource = ingredients;

            await LoadAllIngredients();
        }
        void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var ingredientForm = new Forms.IngredientForm(_ingredientService, new GenericRepository<Unit>()))
            {
                if (ingredientForm.ShowDialog() == DialogResult.OK)
                    if (ingredientForm.Tag is Ingredient i)
                        ingredients.Add(i);
            }
        }
        async void searchTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox textbox)
                return;
            string searchTerm = textbox.Text;
            if (string.IsNullOrWhiteSpace(searchTerm))
                return;
            if (e.KeyCode == Keys.Enter)
            {
                var ings = await _ingredientService.GetAll_Async();

                var resultingIngredients = SearchHandler.FilterList(
                    ings,
                    filteringConditions: (b) => b.Name.ToLower().Contains(searchTerm.ToLower())
                    )
                        .ToList();

                searchSuccessful = resultingIngredients.Count > 0;

                if (!searchSuccessful)
                {
                    MessageBox.Show("No entries found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                textbox.SelectAll();
                ///clear the ingredients list
                ingredients.Clear();
                ///repopulate with the new values
                foreach (var i in resultingIngredients.OrderBy(x => x.Name))
                    ingredients.Add(i);
            }
        }
        async void searchTxt_TextChanged(object sender, EventArgs e)
        {
            if (sender is not TextBox textbox) return;

            var text = textbox.Text;

            if (!string.IsNullOrWhiteSpace(text)) return;

            if (!searchSuccessful) return;

            await LoadAllIngredients();
        }

        async Task LoadAllIngredients()
        {
            var ingredients = await _ingredientService.GetAll_Async();

            this.ingredients.Clear();

            foreach (var i in ingredients.OrderBy(x => x.Name))
                this.ingredients.Add(i);
        }

        async void _delete_Click(object sender, EventArgs e)
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
                if (await DeleteIngredient(SelectedIngredient))
                    ingredients.Remove(SelectedIngredient);
        }
        async Task<bool> DeleteIngredient(Ingredient? ing)
        {
            if (ing is null)
                return false;

            return await _ingredientService.Remove_Async(ing);
        }
        async void _ingredientsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || e.RowIndex == -1)
                return;

            if (e.ColumnIndex == deleteBtnCol.Index &&
                  MessageBox.Show(
                    "Are you sure you want to remove " + SelectedIngredient?.Name + "?",
                    "",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK
                    )
            {
                if (SelectedIngredient is not null)
                    if (await DeleteIngredient(SelectedIngredient))
                        ingredients.Remove(SelectedIngredient);
            }

            if (e.ColumnIndex == editCol.Index)
            {
                using (var ingredientForm = new Forms.IngredientForm(
                    _ingredientService,
                    new GenericRepository<Unit>(),
                    SelectedIngredient
                    ))
                {
                    if (ingredientForm.ShowDialog() == DialogResult.OK)
                        if (ingredientForm.Tag is Ingredient i)
                            SelectedIngredient = i;
                }
            }
        }
    }
}
