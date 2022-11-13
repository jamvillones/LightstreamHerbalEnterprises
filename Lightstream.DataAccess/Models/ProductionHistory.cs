using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class ProductionHistory
    {
        public int Id { get; set; }
        public int QtyProduced { get; set; }
        public DateTime DateTimeProduction { get; set; }
        public Login? Login { get; set; }
        public ProductVariant ProductVariant { get; set; } = null!;
    }
}
