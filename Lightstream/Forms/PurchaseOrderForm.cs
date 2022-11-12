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
    public partial class PurchaseOrderForm : Form
    {

        private BindingList<Ingredient> _ingredients = new BindingList<Ingredient>();
        private BindingList<SupplierToIngredient> _availableSuppliers = new BindingList<SupplierToIngredient>();

        private Ingredient? _selectedIngredient;
        private Ingredient? SelectedIngredient
        {
            get => _selectedIngredient;
            set
            {
                _selectedIngredient = value;

                _availableSuppliers.Clear();

                if (_selectedIngredient is not null)
                    foreach (var i in _selectedIngredient.SupplierToIngredients)
                    {
                        _availableSuppliers.Add(i);
                    }
            }
        }

        private SupplierToIngredient? SelectedBridge => _supplierTable.SelectedRows.Count == 0 ? 
                                                        null : 
                                                        _supplierTable.SelectedRows[0].DataBoundItem as SupplierToIngredient;

        GenericRepository<Ingredient> _ingService;
        public PurchaseOrderForm(GenericRepository<Ingredient> ingService)
        {
            InitializeComponent();
            SetUpBinding();
            _ingService = ingService;
        }
        void SetUpBinding()
        {
            _ingTable.AutoGenerateColumns = false;
            ingredientNameCol.DataPropertyName = nameof(Ingredient.Name);
            _ingTable.DataSource = _ingredients;

            _supplierTable.AutoGenerateColumns = false;
            suppCol.DataPropertyName = nameof(SupplierToIngredient.Supplier);
            costCol.DataPropertyName = nameof(SupplierToIngredient.Cost);
            _supplierTable.DataSource = _availableSuppliers;

        }
        bool searchMade = false;
        private void ingSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ingSearch.Text) && searchMade)
            {
                searchMade = false;
                _ingredients.Clear();
            }
        }

        private async void ingSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            var text = ((TextBox)sender).Text.Trim();

            if (!string.IsNullOrEmpty(text))
                await Search();
        }
        async Task LoadAll()
        {
            _ingredients.Clear();

            var ings = await _ingService.GetAll_Async();

            foreach (var i in ings.OrderBy(x => x.Name))
            {
                _ingredients.Add(i);
            }
        }

        async Task Search()
        {
            _ingredients.Clear();

            var ings = await _ingService.GetAll_Async();

            foreach (var i in ings.OrderBy(x => x.Name))
            {
                _ingredients.Add(i);
            }
        }

        private void _ingTable_SelectionChanged(object sender, EventArgs e)
        {
            if (_ingTable.SelectedRows.Count == 0)
                return;
            SelectedIngredient = _ingredients[_ingTable.SelectedRows[0].Index];
        }

        private async void PurchaseOrderForm_Load(object sender, EventArgs e)
        {
            await LoadAll();
        }

        private void _supplierTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedBridge is not null)
            {
                _cost.Value = SelectedBridge.Cost;
                _supplier.Text = SelectedBridge.Supplier.Name;
            }
        }
    }
}
