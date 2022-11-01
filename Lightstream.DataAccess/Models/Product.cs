using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Product : BaseEntityModel
    {
        public Product()
        {
            Recipes = new HashSet<Recipe>();
            ProductInventories = new HashSet<ProductInventory>();
            ProductionHistory = new HashSet<ProductionHistory>();
        }

        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public virtual Unit UnitQty { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; }
        public ICollection<ProductionHistory> ProductionHistory { get; set; }
        public ICollection<ProductVariant> GetProductVariants { get; set; }
    }
}
