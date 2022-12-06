using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
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
    public partial class ProductForm : Form
    {
        private Product? productReferenced;
        public bool EditMode => productReferenced is not null;
        private BindingList<RecipeViewModel> recipes = new BindingList<RecipeViewModel>();
        BindingList<Unit> units = new BindingList<Unit>();
        private RecipeViewModel? SelectedRecipe => _recipe.RowCount == 0 ? null : _recipe.SelectedRows[0].DataBoundItem as RecipeViewModel;

        GenericRepository<Product> _productService;
        GenericRepository<Unit> _unitService;

        public ProductForm
            (
            GenericRepository<Product> productService,
            GenericRepository<Unit> unitService,
            Product? product = null
            )
        {
            InitializeComponent();
            _productService = productService;
            _unitService = unitService;
            _recipe.AutoGenerateColumns = false;
            _unitOption.DisplayMember = nameof(Unit.SingularName);
            _unitOption.DataSource = units;
            productReferenced = product;

            this.Text = EditMode ? "Edit Product" : "Create Product";
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

        private async void ProductForm_Load(object sender, EventArgs e)
        {
            _unitOption.DataSource = units;
            _recipe.DataSource = recipes;
            await LoadValues();
        }
        async Task LoadValues()
        {
            units.Clear();
            foreach (var unit in await _unitService.GetAll_Async())
                units.Add(unit);

            if (EditMode)
            {
                var prod = productReferenced!;
                _productName.Text = prod.Name;
                _description.Text = prod.Description;
                _barcode.Text = prod.Barcode;
                _unitOption.SelectedItem = units.FirstOrDefault(x => x.Id == prod.UnitQty.Id);

                recipes.Clear();
                foreach (var i in prod.Recipes)
                    recipes.Add(new RecipeViewModel(i));
            }
        }

        private async void _save_Click(object sender, EventArgs e)
        {
            await SaveChanges();
        }

        private async Task SaveChanges()
        {
            if (await ValidationSuccessful())
                if (await SaveProduct())
                    DialogResult = DialogResult.OK;
        }

        async Task<bool> ValidationSuccessful()
        {
            var products = await _productService.GetAll_Async();
            bool BarcodeTaken = false;
            if (EditMode)
                BarcodeTaken = products.Where(p => p.Barcode != productReferenced.Barcode && !string.IsNullOrWhiteSpace(p.Barcode)).Any(p => p.Barcode == _barcode.Text.Trim());
            else
                BarcodeTaken = products.Where(p => !string.IsNullOrWhiteSpace(p.Barcode)).Any(p => p.Barcode == _barcode.Text.Trim());

            if (BarcodeTaken)
            {
                MessageBox.Show("Product number already registered.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (recipes.Count == 0)
            {
                MessageBox.Show("Ingredients cannot be empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (MessageBox.Show("Are you sure you want to save changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;
            return true;
        }
        //DbContextFactory factory = new DbContextFactory();
        async Task<bool> SaveProduct()
        {
            Product? product = null;
            if (EditMode)
                product = await _productService.Update_Async(ProductToBeSaved);
            else
                product = await _productService.Add_Async(ProductToBeSaved);

            this.Tag = product;
            return product != null;
        }

        Product ProductToBeSaved
        {
            get
            {
                return new Product()
                {
                    Id = productReferenced?.Id ?? 0,
                    Name = _productName.Text.Trim(),
                    Barcode = string.IsNullOrWhiteSpace(_barcode.Text) ? null : _barcode.Text.Trim(),
                    Description = string.IsNullOrWhiteSpace(_description.Text) ? null : _description.Text.Trim(),
                    UnitQty = (Unit)_unitOption.SelectedItem,
                    Recipes = recipes.Select(r => r.Data).ToList()
                };
            }
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

        private async void _cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to discard changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) return;
            await LoadValues();
        }

        private void _unitOption_Validated(object sender, EventArgs e)
        {
            var u = units.FirstOrDefault(x => string.Equals(x.SingularName, _unitOption.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (u is null)
                OpenUnitForm();
            else
                _unitOption.SelectedItem = u;
        }

        void OpenUnitForm()
        {
            if (MessageBox.Show("Unit is not recognised. Would you like to register new unit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                return;

            var unitForm = new UnitForm(_unitOption.Text.Trim());
            var result = unitForm.OpenFormModal();

            if (result == DialogResult.OK)
            {
                //var unit = unitForm.Tag as Unit;
                if (unitForm.Tag is Unit unit)
                {
                    units.Add(unit);
                    _unitOption.SelectedItem = unit;
                }
            }
        }
    }
}
