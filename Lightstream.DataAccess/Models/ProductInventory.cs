using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class ProductInventory : BaseEntityModel
    {
        public Product Product { get; set; } = null!;
        public ICollection<SoldProduct> SoldItems { get; set; } = null!;
        public ICollection<ProductionHistory> ProductionHistories { get; set; } = null!;
    }
}
