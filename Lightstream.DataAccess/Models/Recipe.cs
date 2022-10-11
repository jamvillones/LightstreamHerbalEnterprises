using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Recipe
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public int ConversionId { get; set; }
        public int IngredientId { get; set; }
        public int ProductId { get; set; }

        public virtual Conversion Conversion { get; set; } = null!;
        public virtual Ingredient Ingredient { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
