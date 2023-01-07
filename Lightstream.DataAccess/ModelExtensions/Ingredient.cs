using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Ingredient
    {
        public string GetUnit => UnitMeasurement.SingularName;
        public string GetFormattedCost => string.Format("₱ {0:n}", this.Cost);

        public string Status => (IsArchived ? "Inactive" : "Active")+ (IsInCrititcalQty? " - In Critical Qty":"");

        public override string ToString() => Name;

        public bool IsInCrititcalQty => CriticalQty == 0 ? false : Qty <= CriticalQty;

        public decimal Qty
        {
            get
            {
                return OrderedTotal - DeductedTotal;
            }
        }

        public decimal OrderedTotal => PurchaseOrders.Where(x => x.Status == PurchaseOrderStatus.Received).Sum(x => x.Qty);

        public decimal DeductedTotal => Recipes.Select(r => r.Qty * (r.Product.ProductVariants.Select(pv => pv.RequiredQty * (pv.ProductionHistories.Select(ph => ph.QtyProduced).Sum())).Sum())).Sum();
    }
}
