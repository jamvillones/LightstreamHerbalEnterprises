using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Services;
using Lightstream.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream
{
    public partial class FPOS : Form, ILogoutForm
    {
        public bool IsLoggedout { get; private set; } = false;
        private GenericRepository<ProductVariant> _variantService;
        private GenericRepository<Sale> _saleService;
        private BindingList<ProductVariant> _searchedList = new();
        private BindingList<CartItemViewModel> _cart = new();
        private INotifier notificationSource;
        public FPOS(GenericRepository<ProductVariant> variantService, GenericRepository<Sale> saleService, INotifier source = null)
        {
            InitializeComponent();
            notificationSource = source;
            SetUpBinding();
            _variantService = variantService;
            _saleService = saleService;
        }

        void SetUpBinding()
        {
            _cartTable.AutoGenerateColumns = false;
            _searchTable.AutoGenerateColumns = false;

            searchCol_ProductNumber.DataPropertyName = nameof(ProductVariant.ProductNumber);
            searchCol_Name.DataPropertyName = nameof(ProductVariant.ProductName);
            searchCol_Variation.DataPropertyName = nameof(ProductVariant.Description);
            searchCol_Qty.DataPropertyName = nameof(ProductVariant.StockQty);
            searchCol_Price.DataPropertyName = nameof(ProductVariant.Price);

            cartCol_ProductNumber.DataPropertyName = nameof(CartItemViewModel.ProductNumber);
            cartCol_ProductName.DataPropertyName = nameof(CartItemViewModel.ProductName);
            cartCol_Variation.DataPropertyName = nameof(CartItemViewModel.Variation);
            cartCol_Qty.DataPropertyName = nameof(CartItemViewModel.Qty);
            cartCol_Price.DataPropertyName = nameof(CartItemViewModel.Price);

            _cartTable.DataSource = _cart;
            _searchTable.DataSource = _searchedList;
        }

        public void Logout()
        {
            IsLoggedout = true;
            this.Close();
        }
        bool searchMade = false;
        private void srchText_TextChanged(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            var text = textBox!.Text;
            if (searchMade && string.IsNullOrWhiteSpace(text))
            {
                _searchedList.Clear();
                searchMade = false;
            }
        }

        private async void srchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var text = ((TextBox)sender).Text.Trim();
                var variants = await _variantService.GetAll_Async();

                var result = SearchHandler.FilterList(
                    variants.Where(x => x.StockQty > 0),
                    FilteringFlags.StopUponSatisfaction,
                    x => x.ProductNumber == text,
                    x => x.ProductName.ToLower().Contains(text)

                    );

                searchMade = result.Count() > 0;
                if (!searchMade)
                {
                    MessageBox.Show("No Product Found!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _searchedList.Clear();
                foreach (var i in result)
                    _searchedList.Add(i);
            }
        }

        private void _searchTable_SelectionChanged(object sender, EventArgs e)
        {
            if (_searchTable.SelectedCells.Count == 0) return;
            if (_searchTable.SelectedRows[0].DataBoundItem is ProductVariant pv)
            {
                qtyValue.Maximum = pv.StockQty;
                priceValue.Value = pv.Price;
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotalSearch();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotalSearch();
        }

        void ComputeTotalSearch()
        {
            textBox1.Text = string.Format("₱ {0:n}", qtyValue.Value * priceValue.Value);
        }

        private void FPOS_Load(object sender, EventArgs e)
        {
            ComputeTotalSearch();
            ComputeTotalAndChange();
            notificationSource?.ShowNotification("Welcome!", $"Please make sure that the time and date is correct.\nCurrent Date and Time: {DateTime.Now.ToString("MMM d, yyyy h:mm tt")}", ToolTipIcon.Info);
        }
        ProductVariant? selectedVariant => _searchTable.SelectedRows.Count == 0 ? null : _searchTable.SelectedRows[0].DataBoundItem as ProductVariant;
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedVariant is null) return;

            var sp = CheckIfAlreadyPresentOnCart(selectedVariant);

            if (sp is not null)
            {
                if (selectedVariant.StockQty <= (sp.Qty + (int)qtyValue.Value))
                {
                    sp.Qty = selectedVariant.StockQty;
                    return;
                }

                sp.Qty += (int)qtyValue.Value;
                sp.Price = priceValue.Value;
                ComputeTotalAndChange();
                return;
            }
            var cartItem = new SoldProduct()
            {
                ProductVariant = selectedVariant,
                SoldQty = (int)qtyValue.Value,
                SoldPrice = priceValue.Value
            };

            _cart.Add(new CartItemViewModel(cartItem));
            ComputeTotalAndChange();
        }
        CartItemViewModel? CheckIfAlreadyPresentOnCart(ProductVariant v)
        {
            return _cart.FirstOrDefault(x => x.GetData.ProductVariant.Id == v.Id);
        }
        decimal GetVatValue => GetTotal * 0.12m;
        decimal GetTendered => tenderedValue.Value;
        decimal GetTotal => _cart.Select(x => x.Total).Sum();
        decimal GetGrantTotal => GetTotal;
        decimal GetChange => GetTendered - GetGrantTotal;
        void ComputeTotalAndChange()
        {
            VATtextBox.Text = string.Format("₱ {0:n}  (12%)", GetVatValue);
            TOTALtextBox.Text = string.Format("₱ {0:n}", GetTotal);
            GRANDTOTALtextbox.Text = string.Format("₱ {0:n}", GetGrantTotal);
            CHANGEtextBox.Text = string.Format("₱ {0:n}", GetChange);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ComputeTotalAndChange();
        }

        private void _cartTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == removeCol.Index)
            {
                _cart.RemoveAt(e.RowIndex);
            }
        }

        private async void proc_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sale = new Sale()
            {
                SoldProducts = _cart.Select(x => x.GetData).ToList(),
            };

            if(GetTendered > 0)
            {
                sale.PaymentRecords.Add(new PaymentRecord() { Amount = GetTendered });
            }

            var result = await _saleService.Add_Async(sale);
            if (result is not null)
            {
                MessageBox.Show("Transaction successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }
        void Reset()
        {
            _cart.Clear();
            _searchedList.Clear();
            qtyValue.Value = qtyValue.Minimum;
            priceValue.Value = priceValue.Minimum;
            tenderedValue.Value = tenderedValue.Minimum;
            ComputeTotalAndChange();
        }
    }
}
