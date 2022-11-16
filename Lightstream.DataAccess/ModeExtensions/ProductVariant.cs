using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class ProductVariant
    {
        public string RequiredAmount => RequiredQty.ToString("#,#0.####") +" "+ (RequiredQty > 1? Product.UnitQty.PluralName : Product.UnitQty.SingularName);

        public string ProductName => Product.Name;
        public string ProductNumber => Product.Barcode;
        public int StockQty => ProductionHistories.Select(x => x.QtyProduced).Sum() - SoldProducts.Select(x=>x.SoldQty).Sum();
    }
}
