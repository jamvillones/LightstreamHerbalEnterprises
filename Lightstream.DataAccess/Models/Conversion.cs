using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Conversion
    {
        public Conversion()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public int FromUnitId { get; set; }
        public int ToUnitId { get; set; }        
        public decimal Value { get; set; }
        public virtual Unit FromUnit { get; set; } = null!;
        public virtual Unit ToUnit { get; set; } = null!;
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
