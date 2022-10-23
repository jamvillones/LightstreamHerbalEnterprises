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
        /// <summary>
        /// Login who produced
        /// </summary>
        public Login? Login { get; set; }
        /// <summary>
        /// PRODUCT produced
        /// </summary>
        public Product Product { get; set; } = null!;
    }
}
