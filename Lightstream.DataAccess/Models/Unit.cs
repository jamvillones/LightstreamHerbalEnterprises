using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Unit : IIDModel, IArchivable
    {
        public Unit()
        {
            ConversionFromUnits = new HashSet<Conversion>();
            ConversionToUnits = new HashSet<Conversion>();
            Ingredients = new HashSet<Ingredient>();
        }

        public int Id { get; set; }
        public string SingularName { get; set; } = null!;
        public string? PluralName { get; set; } = null;
        public string? Abbreviation { get; set; } = null;
        public bool IsArchived { get; set; } = false;
        public virtual ICollection<Conversion> ConversionFromUnits { get; set; }
        public virtual ICollection<Conversion> ConversionToUnits { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
