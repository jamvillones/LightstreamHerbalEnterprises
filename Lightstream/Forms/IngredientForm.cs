using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
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
    public partial class IngredientForm : Form
    {
        public string IngredientName => nameTxt.Text.Trim();
        public Unit? SelectedUnit => unitOption.SelectedItem as Unit;
        public decimal Cost => cost.Value;

        BindingList<Unit> units = new BindingList<Unit>();

        GenericRepository<Ingredient> _ingService;
        GenericRepository<Unit> _unitService;

        private Ingredient _referecencedIngredient;
        public Ingredient ReferencedIngredient
        {
            get => _referecencedIngredient;
            set
            {
                _referecencedIngredient = value;

                nameTxt.Text = _referecencedIngredient?.Name;
                cost.Value = _referecencedIngredient?.Cost ?? cost.Minimum;
                numericUpDown1.Value = _referecencedIngredient.CriticalQty;

                this.Text = _referecencedIngredient is null ? "Create Ingredient" : "Edit Ingredient";
                this.addBtn.Text = _referecencedIngredient is null ? "Add" : "Update";
            }
        }

        bool EditMode => ReferencedIngredient is not null;

        public IngredientForm(GenericRepository<Ingredient> ingService, GenericRepository<Unit> unitService, Ingredient? ingredient = null)
        {
            InitializeComponent();

            _ingService = ingService;
            _unitService = unitService;

            ReferencedIngredient = ingredient;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (!await ValidateFields())
            {
                return;
            }
            /// create new ingredient
            var ingredient = new Ingredient()
            {
                Id = ReferencedIngredient?.Id ?? 0,
                Name = this.IngredientName,
                Cost = this.Cost,
                CriticalQty = numericUpDown1.Value,
                UnitMeasurement = SelectedUnit
            };

            await _ingService.Add_Async(ingredient);

            if (ReferencedIngredient is not null)
                ingredient.Recipes = ReferencedIngredient.Recipes;

            Tag = ingredient;

            DialogResult = DialogResult.OK;
        }

        private async Task<bool> ValidateFields()
        {

            if (string.IsNullOrWhiteSpace(Name))
            {
                MessageBox.Show("Name cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!EditMode)
            {
                var ings = await _ingService.GetAll_Async();
                if (ings.Any(i => string.Equals(i.Name, this.IngredientName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Name already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;


        }

        private async void IngredientsForm_Load(object sender, EventArgs e)
        {
            var units = await _unitService.GetAll_Async();
            foreach (var u in units.OrderBy(x => x.SingularName))
                this.units.Add(u);

            unitOption.DataSource = units;

            if (EditMode)
                unitOption.SelectedItem = units.FirstOrDefault(x => x.Id == ReferencedIngredient.UnitMeasurement.Id);
        }

        private void nameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
