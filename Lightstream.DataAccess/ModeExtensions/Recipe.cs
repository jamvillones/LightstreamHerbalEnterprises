using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Recipe
    {
        public string DisplayMember => this.Qty + " " + GetUnit + " of " + Ingredient.Name;
        public string GetUnit => Conversion == null ? Ingredient.UnitMeasurement.SingularName : Conversion.FromUnit.SingularName;
    }
}
