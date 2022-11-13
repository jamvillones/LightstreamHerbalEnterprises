using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class ProductVariant
    {
        public string RequiredAmount => RequiredQty.ToString().TrimEnd('0','.') +" "+ (RequiredQty > 1? Product.UnitQty.PluralName : Product.UnitQty.SingularName);
    }
}
