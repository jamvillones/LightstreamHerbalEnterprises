using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class PurchaseOrder
    {
        public decimal Total => Qty * Cost;
        //public string TotalString => string.Format("₱ {0:n}", Total);
        //public string CostString => string.Format("₱ {0:n}", Cost);
        //public string DateOrderedString => DateOrdered.ToString("MMM d, yyyy h:mm tt");
    }
}
