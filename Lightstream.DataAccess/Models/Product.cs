using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Product : BaseEntityModel
    {
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public virtual Unit UnitQty { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; } =  new HashSet<Recipe>();
        public ICollection<ProductVariant> ProductVariants { get; set; } = new HashSet<ProductVariant>();
    }
}
