using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
using Lightstream.Services;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream
{
    public partial class PurchaseOrderPage : Form
    {
        private GenericRepository<PurchaseOrder> _poService;

        BindingList<PurchaseOrder> _poList = new BindingList<PurchaseOrder>();

        private PurchaseOrder? SelectedPO
        {
            get => _poTable.SelectedRows.Count == 0 ? null : _poList[_poTable.SelectedRows[0].Index];
            set => _poList[_poTable.SelectedRows[0].Index] = value!;
        }

        public PurchaseOrderPage(GenericRepository<PurchaseOrder> service)
        {
            InitializeComponent();
            LoadTableBindings();
            _poService = service;
        }

        void LoadTableBindings()
        {
            _poTable.AutoGenerateColumns = false;

            poNumCol.DataPropertyName = nameof(PurchaseOrder.Id);
            ingCol.DataPropertyName = nameof(PurchaseOrder.Ingredient);
            supplierCol.DataPropertyName = nameof(PurchaseOrder.Supplier);
            qtyCol.DataPropertyName = nameof(PurchaseOrder.Qty);
            dateCol.DataPropertyName = nameof(PurchaseOrder.DateOrdered);
            costCol.DataPropertyName = nameof(PurchaseOrder.Cost);
            totalCol.DataPropertyName = nameof(PurchaseOrder.Total);
            statusCol.DataPropertyName = nameof(PurchaseOrder.Status);

            _poTable.DataSource = _poList;
        }

        private async void PurchaseOrderPage_Load(object sender, EventArgs e)
        {
            await LoadPOs(selectedStatus);
        }

        async Task LoadPOs(PurchaseOrderStatus status = PurchaseOrderStatus.Pending)
        {
            var list = await _poService.GetAll_Async();

            if (status != PurchaseOrderStatus.All)
                list = list.Where(x => x.StatusType == (int)status);

            _poList.Clear();
            foreach (var i in list)
                _poList.Add(i);
        }

        private void _newPO_Click(object sender, EventArgs e)
        {
            var newPo = OpenPOForm();

            if (newPo is null) return;

            _poList.Add(newPo);
        }

        PurchaseOrder? OpenPOForm()
        {
            using (var form = new PurchaseOrderForm(new Ingredient_Supplier_Service(), new GenericRepository<PurchaseOrder>()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (form.Tag is PurchaseOrder po)
                    {
                        return po;
                    }
                }
            }
            return null;
        }

        private void _poTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var status = (PurchaseOrderStatus)_poList[e.RowIndex].StatusType;
            FormatRow(_poTable.Rows[e.RowIndex], status);
        }

        Color colorPending = Color.Gray;
        Color colorIncomplete = Color.FromArgb(255, 255, 170);
        Color colorRecieved = Color.FromArgb(180, 210, 180);
        Color colorCancelled = Color.FromArgb(221, 146, 146);

        void FormatRow(DataGridViewRow row, PurchaseOrderStatus status)
        {
            Color rowColor = Color.White;

            switch (status)
            {
                case PurchaseOrderStatus.Incomplete:
                    rowColor = colorIncomplete;
                    break;
                case PurchaseOrderStatus.Received:
                    rowColor = colorRecieved;
                    break;
                case PurchaseOrderStatus.Cancelled:
                    rowColor = colorCancelled;
                    break;
            }

            row.DefaultCellStyle.BackColor = rowColor;
        }

        private async void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            selectedStatus = PurchaseOrderStatus.Pending;
            await LoadPOs(selectedStatus);
        }

        private async void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            selectedStatus = PurchaseOrderStatus.Incomplete;
            await LoadPOs(selectedStatus);
        }

        private async void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selectedStatus = PurchaseOrderStatus.Received;
            await LoadPOs(selectedStatus);
        }

        private async void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedStatus = PurchaseOrderStatus.Cancelled;
            await LoadPOs(selectedStatus);
        }

        private async void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedStatus = PurchaseOrderStatus.All;
            await LoadPOs(selectedStatus);
        }

        private void _poTable_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedPO is null) return;
            FormatCancelButton(SelectedPO.Status);
        }

        void FormatCancelButton(PurchaseOrderStatus status)
        {
            bool isPending = status == PurchaseOrderStatus.Pending;
            _cancelOrder.Enabled = isPending;
            button1.Enabled = isPending;
            button2.Enabled = isPending || status == PurchaseOrderStatus.Incomplete;
        }

        async Task ChangePoStatus(PurchaseOrderStatus status)
        {
            if (SelectedPO is null)
                return;

            var spo = SelectedPO;
            spo.StatusType = (int)status;

            SelectedPO = await _poService.Update_Async(spo);
        }

        async void _cancelOrder_Click(object sender, EventArgs e)
        {
            await ChangePoStatus(PurchaseOrderStatus.Cancelled);
            if (SelectedPO is not null)
                FormatCancelButton(SelectedPO.Status);
        }

        async void button1_Click(object sender, EventArgs e)
        {
            await ChangePoStatus(PurchaseOrderStatus.Incomplete);
            if (SelectedPO is not null)
                FormatCancelButton(SelectedPO.Status);
        }

        async void button2_Click(object sender, EventArgs e)
        {
            await ChangePoStatus(PurchaseOrderStatus.Received);
            if (SelectedPO is not null)
                FormatCancelButton(SelectedPO.Status);
        }

        bool searchMade = false;

        private async void _search_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = sender as TextBox;
            if (e.KeyCode != Keys.Enter || string.IsNullOrWhiteSpace(textBox.Text)) return;

            var text = textBox!.Text.Trim().ToLower();
            var list = await _poService.GetAll_Async();

            var result = SearchHandler.FilterList(list, FilteringFlow.StopUponSatisfaction,
                x => x.Ingredient.Name.ToLower().Contains(text),
                x => x.Supplier.Name.ToLower().Contains(text)
                );

            searchMade = result.Count() > 0;

            if (!searchMade)
            {
                MessageBox.Show("No Purchase Order found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _poList.Clear();
            foreach (var po in result)
                _poList.Add(po);
        }

        PurchaseOrderStatus selectedStatus = PurchaseOrderStatus.Pending;

        private async void _search_TextChanged(object sender, EventArgs e)
        {
            var text = sender as TextBox;

            if (string.IsNullOrWhiteSpace(text.Text))
                await LoadPOs(selectedStatus);
        }
    }
}
