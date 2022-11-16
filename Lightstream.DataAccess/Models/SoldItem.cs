using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class SoldProduct : IIDModel
    {
        public SoldProduct()
        {
            
        }
        public int Id { get; set; }
        public decimal SoldPrice { get; set; }
        public int SoldQty { get; set; }        
        public ProductVariant ProductVariant { get; set; }
    }
}
