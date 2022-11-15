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

namespace Lightstream.Pages
{
    public partial class SalePage : Form
    {
        GenericRepository<Sale> _saleService;
        BindingList<Sale> _sales = new();
        public SalePage(GenericRepository<Sale> saleService)
        {
            InitializeComponent();
            _saleService = saleService;
            SetupBinding();
        }
        void SetupBinding()
        {
            _saleTable.AutoGenerateColumns = false;

            dateCol.DataPropertyName = nameof(Sale.DateTimeTransaction);
            customerCol.DataPropertyName = nameof(Sale.CustomerName);
            userCol.DataPropertyName = nameof(Sale.UserName);
            totalCol.DataPropertyName = nameof(Sale.GrandTotal);
            totalPaymentCol.DataPropertyName = nameof(Sale.TotalPayment);
            statusCol.DataPropertyName = nameof(Sale.Status);

            _saleTable.DataSource = _sales;
        }

        async Task LoadDataAsync()
        {
            var sales = await _saleService.GetAll_Async();

            _sales.Clear();

            foreach (var s in sales.OrderByDescending(x=>x.Id))
                _sales.Add(s);
        }

        private async void SalePage_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
