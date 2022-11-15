using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Services;
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
    public partial class IngredientsPicker : Form
    {
        public Ingredient? SelectedIngredient
        {
            get
            {
                if (_ingredientsTable.RowCount == 0) return null;
                return _ingredientsTable.SelectedRows[0].DataBoundItem as Ingredient;
            }
        }
        public decimal Cost => _cost.Value;

        BindingList<Ingredient> ingredients = new();
        private GenericRepository<Ingredient> ingService;
        IEnumerable<Ingredient> pickedIngredients;
        public IngredientsPicker(GenericRepository<Ingredient> ingService, IEnumerable<Ingredient> pickedIngredients = null)
        {
            InitializeComponent();
            this.ingService = ingService;
            this.pickedIngredients = pickedIngredients;
            SetDataGridColumnBindings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void IngredientsPicker_Load(object sender, EventArgs e)
        {
            await LoadIngredient();
        }

        async Task LoadIngredient()
        {
            var ingredients = await ingService.GetAll_Async();

            if (pickedIngredients is not null)
                ingredients = ingredients.Where(x => !pickedIngredients.Any(a => a.Id == x.Id));

            this.ingredients.Clear();

            foreach (var i in ingredients.OrderBy(x => x.Name))
                this.ingredients.Add(i);
        }
        void SetDataGridColumnBindings()
        {
            _ingredientsTable.AutoGenerateColumns = false;

            nameCol.DataPropertyName = nameof(Ingredient.Name);

            _ingredientsTable.DataSource = ingredients;
        }

        private void _ingredientsTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
                return;

            // Tag = SelectedIngredient;

            DialogResult = DialogResult.OK;
        }

        private void _save_Click(object sender, EventArgs e)
        {
            if (SelectedIngredient is null) return;
            Tag = SelectedIngredient;
            DialogResult = DialogResult.OK;
        }

        bool SearchSuccessful = false;
        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(seachField.Text))
            {
                await Search(seachField.Text.Trim());
            }
        }
        async Task Search(string keyword)
        {
            var ingredients = await ingService.GetAll_Async();

            if (pickedIngredients is not null)
                ingredients = ingredients.Where(x => !pickedIngredients.Any(a => a.Id == x.Id));

            var filtered = SearchHandler.FilterList(
                ingredients,
                FilteringFlags.StopUponSatisfaction,
                i => i.Name.ToLower().Contains(keyword.ToLower()));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No ingredient/s found.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SearchSuccessful = true;

            _ingredientsTable.Rows.Clear();
            foreach (var i in filtered.OrderBy(x => x.Name))
                this.ingredients.Add(i);
        }
        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(seachField.Text) && SearchSuccessful)
            {
                SearchSuccessful = false;
                await LoadIngredient();
            }
        }

        private void _ingredientsTable_SelectionChanged(object sender, EventArgs e)
        {
            _cost.Value = SelectedIngredient?.Cost ?? _cost.Minimum;
        }
    }
}
