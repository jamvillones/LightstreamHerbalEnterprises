using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Ingredient
    {
        public Ingredient()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public int UnitMeasurementId { get; set; }
        public decimal Cost { get; set; }
        public string Name { get; set; } = null!;

        public virtual Unit UnitMeasurement { get; set; } = null!;
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
