using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public sealed class Ingredient : DomainObject
    {
        public string UnitOfMeasurement { get; set; }
        public decimal Cost { get; set; }

        public ICollection<IngredientWithQty> Product { get; set; }
    }
}
