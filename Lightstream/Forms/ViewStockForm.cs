using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Forms
{
    partial class ViewStockForm : Form
    {
        private GenericRepository<ProductVariant> _prodService;

        private Product _refProduct;

        BindingList<ProductVariant> _variants = new();
        BindingList<ProductionHistory> _stockins = new();

        public Product RefProduct
        {
            get { return _refProduct; }
            set
            {
                _refProduct = value;

                this.Text = this.Text + " Product: " + RefProduct.Name;
            }
        }

        ProductVariant? _selected;
        ProductVariant? SelectedVariant
        {
            get => _selected;
            set
            {
                _selected = value;

                if (_selected is null) return;

                _stockins.Clear();

                foreach (var i in _selected.ProductionHistories)
                    _stockins.Add(i);
            }
        }

        public ViewStockForm(GenericRepository<ProductVariant> productService, Product product)
        {
            InitializeComponent();
            _prodService = productService;
            RefProduct = product;

            SetBindings();
        }

        void SetBindings()
        {
            _variantsTable.AutoGenerateColumns = false;
            _stockinsTable.AutoGenerateColumns = false;

            nameCol.DataPropertyName = nameof(ProductVariant.Description);
            stockCol.DataPropertyName = nameof(ProductVariant.StockQty);

            stockinQtyCol.DataPropertyName = nameof(ProductionHistory.QtyProduced);
            dateProducedCol.DataPropertyName = nameof(ProductionHistory.DateTimeProduction);

            _variantsTable.DataSource = _variants;
            _stockinsTable.DataSource = _stockins;
        }

        private void ViewStockForm_Load(object sender, EventArgs e)
        {
            foreach (var v in RefProduct.ProductVariants.Where(pv=>!pv.IsArchived))
                _variants.Add(v);
        }

        private void _variantsTable_SelectionChanged(object sender, EventArgs e)
        {
            SelectedVariant = _variantsTable.SelectedRows[0].DataBoundItem as ProductVariant;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newProdHistory = new ProductionHistory()
            {
                DateTimeProduction = DateTime.Now,
                QtyProduced = (int)numericUpDown1.Value,
            };

            _stockins.Add(newProdHistory);
        }

        private void _stockinsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var newlyAdddeEntity = _stockins[e.RowIndex];
            var rows = _stockinsTable.Rows[e.RowIndex];
            rows.DefaultCellStyle.ForeColor = newlyAdddeEntity.Id == 0 ? Color.Gray : Color.Black;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var variant = _variantsTable.SelectedRows[0].DataBoundItem as ProductVariant;
            variant.ProductionHistories = _stockins.ToList();

            var result = await _prodService.Update_Async(variant);

            if (result is not null)
            {
                _variants[_variantsTable.SelectedRows[0].Index] = result;
                SelectedVariant = result;
                MessageBox.Show("Save successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _stockinsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == stockRemoveCol.Index)
            {
                _stockins.RemoveAt(e.RowIndex);
            }
        }
    }
}
