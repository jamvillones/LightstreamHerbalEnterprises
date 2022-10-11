using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Unit
    {
        public Unit()
        {
            ConversionFromUnits = new HashSet<Conversion>();
            ConversionToUnits = new HashSet<Conversion>();
            Ingredients = new HashSet<Ingredient>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Conversion> ConversionFromUnits { get; set; }
        public virtual ICollection<Conversion> ConversionToUnits { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
