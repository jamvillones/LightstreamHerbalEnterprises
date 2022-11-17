using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        GenericRepository<PurchaseOrder> _poService;
        public PurchaseOrderForm(GenericRepository<Ingredient> ingService, GenericRepository<PurchaseOrder> poService)
        {
            InitializeComponent();
            SetUpBinding();
            _ingService = ingService;
            _poService = poService;
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
        private async void ingSearch_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;

            if (string.IsNullOrWhiteSpace(text.Text) && searchMade)
            {
                searchMade = false;

                await LoadAll();
            }
        }

        private async void ingSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            Debug.WriteLine(e.KeyCode);

            var text = ((TextBox)sender).Text.Trim();

            if (!string.IsNullOrWhiteSpace(text))
                await Search(text);
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

        async Task Search(string text)
        {

            var ings = await _ingService.GetAll_Async();

            var result = SearchHandler.FilterList(
                ings,
                FilteringFlags.StopUponSatisfaction,
                x => x.Name.ToLower().Contains(text.ToLower()));

            searchMade = result.Count() > 0;
            if (!searchMade)
                return;

            _ingredients.Clear();
            foreach (var i in result.OrderBy(x => x.Name))
            {
                _ingredients.Add(i);
            }
        }

        private void _ingTable_SelectionChanged(object sender, EventArgs e)
        {
            SelectedIngredient = _ingredients.Count == 0 ? null : _ingredients[_ingTable.SelectedRows[0].Index];
            _add.Enabled = CanAddNewPO;
        }
        bool CanAddNewPO => SelectedIngredient is not null && SelectedBridge is not null;
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

        private async void _add_Click(object sender, EventArgs e)
        {
            if (ValidatoinSuccessful())
            {
                Tag = await SavePO();
                DialogResult = DialogResult.OK;
            }
        }

        bool ValidatoinSuccessful()
        {
            return CanAddNewPO;
        }
        async Task<PurchaseOrder> SavePO()
        {
            var poAdded = new PurchaseOrder()
            {
                Ingredient = SelectedIngredient,
                Supplier = SelectedBridge.Supplier,
                Qty = (int)_qty.Value,
                Cost = _cost.Value
            };
            return await _poService.Update_Async(poAdded);
        }
    }
}
