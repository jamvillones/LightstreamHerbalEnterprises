using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Forms;
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
            //dateCol.DataPropertyName = nameof(PurchaseOrder.DateOrderedString);
            dateCol.DataPropertyName = nameof(PurchaseOrder.DateOrdered);
            costCol.DataPropertyName = nameof(PurchaseOrder.Cost);
            totalCol.DataPropertyName = nameof(PurchaseOrder.Total);

            _poTable.DataSource = _poList;
        }

        private async void PurchaseOrderPage_Load(object sender, EventArgs e)
        {
            await LoadPOs();
        }

        async Task LoadPOs()
        {
            var list = await _poService.GetAll_Async();
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
    }
}
