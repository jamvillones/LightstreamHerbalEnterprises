using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.Extensions;
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
        private Product productReferenced;
        DbContextFactory factory = new DbContextFactory();
        private BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        private RecipeViewModel? SelectedRecipe => _recipe.RowCount == 0 ? null : _recipe.SelectedRows[0].DataBoundItem as RecipeViewModel;
        BindingList<Unit> units = new BindingList<Unit>();
        Unit? SelectedUnit
        {
            get => _unitOption.SelectedItem is Unit unit ? unit : null;
            set => _unitOption.SelectedItem = value;
        }
        public EditProductForm(Product product)
        {
            InitializeComponent();
            _recipe.AutoGenerateColumns = false;
            _unitOption.DisplayMember = nameof(Unit.SingularName);
            _unitOption.DataSource = units;
            this.productReferenced = product;
        }

        private void addIngBtn_Click(object sender, EventArgs e)
        {
            using (var recimeForm = new RecipeForm())
            {
                if (recimeForm.ShowDialog() == DialogResult.OK)
                {
                    var recipe = recimeForm.RecipeDetails;
                    if (RecipeValidationSuccessfull(recipe))
                        recipes.Add(new RecipeViewModel(recipe));
                    else
                        MessageBox.Show("Ingredient " + recipe.Ingredient.Name + " is already listed.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool RecipeValidationSuccessfull(Recipe recipe)
        {
            if (recipes.Count == 0)
                return true;

            return !recipes.Any(x => x.Data.Ingredient.Id == recipe.Ingredient.Id);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _unitOption.DataSource = units;
            _recipe.DataSource = recipes;
            LoadValues();

        }
        void LoadValues()
        {
            recipes.Clear();
            using (var context = factory.CreateDbContext())
            {
                units.Clear();
                var u = context.Units.ToList();
                foreach (var i in u)
                    units.Add(i);

                var prod = context.Products
                    .Include(x => x.Recipes)
                    .ThenInclude(r => r.Ingredient)
                    .ThenInclude(r => r.UnitMeasurement)
                    .FirstOrDefault(y => y.Id == productReferenced.Id);
                if (prod is null)
                    return;

                _productName.Text = prod.Name;
                _description.Text = prod.Description;
                _barcode.Text = prod.Barcode;
                SelectedUnit = units.FirstOrDefault(x => x.Id == prod.UnitQty.Id);

                foreach (var i in prod.Recipes)
                    recipes.Add(new RecipeViewModel(i));
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void _save_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            if (ValidationSuccessful())
                if (SaveProduct())
                    DialogResult = DialogResult.OK;
            ///throw new NotImplementedException();
        }

        bool ValidationSuccessful()
        {
            if (MessageBox.Show("Are you sure you want to save changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;
            if (recipes.Count == 0)
            {
                MessageBox.Show("Ingredients cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        //DbContextFactory factory = new DbContextFactory();
        bool SaveProduct()
        {
            using (var context = factory.CreateDbContext())
            {
                if (context.Products
                    .Where(x => x.Id != productReferenced.Id)
                    .Any(y => y.Barcode == productReferenced.Barcode))
                {
                    MessageBox.Show("Barcode already taken!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                var productTobeSaved = context.Products
                    .Include(p => p.Recipes)
                    .FirstOrDefault(x => x.Id == productReferenced.Id);

                if (productTobeSaved is null) return false;

                productTobeSaved.Name = _productName.Text.Trim();
                productTobeSaved.Description = _description.Text.Trim();
                productTobeSaved.UnitQty = context.Units.FirstOrDefault(x => x.Id == SelectedUnit.Id) ?? new Unit() { SingularName = _unitOption.Text.Trim() };
                ///remove the recipes that is no longer available
                foreach (var i in productTobeSaved.Recipes.ToList())
                {
                    bool isDeleted = !recipes.Any(x => x.Data.Id == i.Id);
                    if (isDeleted)
                        productTobeSaved.Recipes.Remove(i);
                }
                ///add newly added recipes
                foreach (var i in recipes.Where(r => r.Data.Id == 0))
                {
                    productTobeSaved.Recipes.Add(new Recipe()
                    {
                        Qty = i.Qty,
                        ConversionId = i.Data.Conversion?.Id,
                        IngredientId = i.Data.Ingredient.Id
                    });
                }
                context.SaveChanges();
                return true;
            }

            //return false;
        }

        private void _recipe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ///check if the clicked row is the header(indexed -1) or the clicked column is not the delete column
            ///if yes then abort
            if (e.RowIndex == -1 || e.ColumnIndex != delCol.Index)
                return;
            RemoveRecipe(e.RowIndex);

        }
        void RemoveRecipe(int rowIndex)
        {
            recipes.RemoveAt(rowIndex);
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to discard changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) return;
            LoadValues();
        }

        private void _unitOption_Validated(object sender, EventArgs e)
        {
            var u = units.FirstOrDefault(x => string.Equals(x.SingularName, _unitOption.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (u is null)
                OpenUnitForm();
            else
                SelectedUnit = u;
        }

        void OpenUnitForm()
        {
            if (MessageBox.Show("Unit is not recognised. Would you like to register new unit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            var unitForm = new UnitForm(_unitOption.Text.Trim());
            var result = unitForm.OpenFormModal();

            if (result == DialogResult.OK)
            {
                var unit = unitForm.ResultingUnit;
                units.Add(unit);
                _unitOption.SelectedItem = unit;
            }

        }
    }
}
