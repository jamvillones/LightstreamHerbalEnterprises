using Lightstream.DataAccess.Models;
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
    public partial class SaleDetails : Form
    {
        Sale _sale;
        BindingList<SoldProduct> soldProducts = new();
        BindingList<PaymentRecord> paymentRecords = new();
        public SaleDetails(Sale sale)
        {
            InitializeComponent();
            _sale = sale;
            SetupBinding();
        }
        void SetupBinding()
        {
            _paymentHistoryTable.AutoGenerateColumns = false;
            _soldProductsTable.AutoGenerateColumns = false;

            colProductNumber.DataPropertyName = nameof(SoldProduct.ProductNumber);
            colProduct.DataPropertyName = nameof(SoldProduct.ProductDetail);
            colQty.DataPropertyName = nameof(SoldProduct.SoldQty);
            colPrice.DataPropertyName = nameof(SoldProduct.SoldPrice);

            colAmount.DataPropertyName = nameof(PaymentRecord.Amount);
            colDate.DataPropertyName = nameof(PaymentRecord.PaymentDate);

            _paymentHistoryTable.DataSource = paymentRecords;
            _soldProductsTable.DataSource = soldProducts;
        }

        private void SaleDetails_Load(object sender, EventArgs e)
        {
            _Id.Text = _sale.Id.ToString();
            _dateTime.Text = _sale.DateTimeTransaction.ToString("MMMM d, yyyy h:mm tt");
            _customer.Text = _sale.CustomerName??"Walk in";
            _grandTotal.Text = string.Format("Grand Total: ₱ {0:n}", _sale.GrandTotal);
            _totalPayment.Text = string.Format("Total Payment: ₱ {0:n}", _sale.TotalPayment);
            _balance.Text = string.Format("Remaining Balance: ₱ {0:n}", _sale.Balance);

            foreach (var i in _sale.SoldProducts)
                soldProducts.Add(i);
            foreach (var i in _sale.PaymentRecords)
                paymentRecords.Add(i);
        }

        private void _totalPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
