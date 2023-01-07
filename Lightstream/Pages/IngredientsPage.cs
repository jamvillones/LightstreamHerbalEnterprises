using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
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
            get
            {
                if (_ingredientsTable.SelectedRows.Count == 0)
                    return null;

                return _ingredientsTable.SelectedRows[0].DataBoundItem as Ingredient;
            }

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
        }

        void IngredientUserControl_Load(object sender, EventArgs e)
        {
            SetBindings();
            _statusOption.LoadArchiveStatus();
        }

        private void SetBindings()
        {
            _ingredientsTable.AutoGenerateColumns = false;

            nameCol.DataPropertyName = nameof(Ingredient.Name);
            defCostCol.DataPropertyName = nameof(Ingredient.Cost);
            qtyCol.DataPropertyName = nameof(Ingredient.Qty);
            unitCol.DataPropertyName = nameof(Ingredient.GetUnit);
            statusCol.DataPropertyName = nameof(Ingredient.Status);

            _ingredientsTable.DataSource = ingredients;
        }

        void addNewBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add Ingredients?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return;

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

            await LoadAllIngredientsAsync();
        }

        async Task LoadAllIngredientsAsync()
        {
            var ingredients = await _ingredientService.GetAll_Async();
            //var i = (ArchiveStatus)_statusOption.SelectedIndex;
            var filtered = ingredients.FilterByStatus(_statusOption.SelectedIndex);

            this.ingredients.Clear();
            foreach (var i in filtered.OrderBy(x => x.Name))
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
        private ArchiveStatus CurrentSelectedStatus = ArchiveStatus.Active;
        private async void _statusOption_SelectedIndexChanged(object sender, EventArgs e)
        {
           await  ChangeSelectionStatus((ArchiveStatus)_statusOption.SelectedIndex);
           // await LoadAllIngredientsAsync();
        }

        private async Task ChangeSelectionStatus(ArchiveStatus nextStatus)
        {
            CurrentSelectedStatus = nextStatus;

            await LoadAllIngredientsAsync();
        }

        Color CriticalQtyColor = Color.FromArgb(238, 200, 200);
        private void _ingredientsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var si = ingredients[e.RowIndex];
            var row = _ingredientsTable.Rows[e.RowIndex];

            if (si.IsInCrititcalQty)
                row.DefaultCellStyle.BackColor = CriticalQtyColor;

            row.SetRowColor(si.IsArchived);
        }

        private async void _archive_retrieve_Click(object sender, EventArgs e)
        {
            var s = SelectedIngredient;
            if (s is null) return;

            await _ingredientService.ToggleArchiveAsync(s!);

            var row = _ingredientsTable.SelectedRows[0];
            row.SetRowColor(s.IsArchived);
            _archive_retrieve.SetButtonBehavior(s.IsArchived);

            if (StatusNotMatched(s.IsArchived, CurrentSelectedStatus))
                ingredients.Remove(s);
        }

        private bool StatusNotMatched(bool status, ArchiveStatus selectedStatus)
        {
            return (status && selectedStatus == ArchiveStatus.Active || !status && selectedStatus == ArchiveStatus.Inactive);
        }

        private void _ingredientsTable_SelectionChanged(object sender, EventArgs e)
        {
            var s = SelectedIngredient;
            if (s is null) return;
            _archive_retrieve.SetButtonBehavior(s.IsArchived);
        }
    }
}
