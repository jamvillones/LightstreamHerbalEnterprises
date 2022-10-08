using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public sealed class Product : DomainObject
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<IngredientWithQty> RequiredIngredient { get; set; }

    }
}
