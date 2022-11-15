using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Sale
    {
        public decimal TotalPayment => PaymentRecords.Select(x => x.Amount).Sum();
        public decimal GrandTotal => SoldProducts.Select(x => x.Total).Sum();
        public bool PaymentCompleted => TotalPayment >= GrandTotal;
        public string? CustomerName => Customer?.Name;
        public string? UserName => Login?.FullName;

        public SaleStatus Status
        {
            get
            {
                if (PaymentCompleted)
                    return SaleStatus.Paid;
                if (PaymentRecords.Count > 0 && !PaymentCompleted)
                    return SaleStatus.Incomplete;

                return SaleStatus.Pending;
            }
        }

    }
}
