using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class SoldProduct
    {
        public string ProductName => ProductVariant.ProductName;
        public string ProductNumber => ProductVariant.ProductNumber;
        public string Variation => ProductVariant.Description;

        public decimal Total => SoldQty * SoldPrice;
    }
}
