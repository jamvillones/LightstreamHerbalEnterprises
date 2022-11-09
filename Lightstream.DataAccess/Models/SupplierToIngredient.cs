using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public class SupplierToIngredient : IIDModel
    {
        public Ingredient Ingredient { get; set; }
        public Supplier Supplier { get; set; }
        public int Id { get; set; }
    }
}
