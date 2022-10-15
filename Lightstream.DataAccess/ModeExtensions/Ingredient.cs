using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Ingredient
    {
        public string GetUnit => UnitMeasurement.Name;
        public string GetFormattedCost => string.Format("₱ {0:n}", this.Cost);
    }
}
