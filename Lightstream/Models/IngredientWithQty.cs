using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public sealed class IngredientWithQty
    {
        public int Id { get; set; }
        public decimal ValuePerQuantity { get; set; }
        public int Qty { get; set; }
        public string Measurement { get; set; }

        public Ingredient Ingredient { get; set; }
        public Product Product { get; set; }

    }
}
