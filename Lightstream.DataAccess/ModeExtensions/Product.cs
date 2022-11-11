using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Product
    {
        public string GetUnit => UnitQty.SingularName;
        public string GetIngredients
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var r in Recipes)
                    sb.AppendLine("● " + r.Qty.ToString().TrimEnd('0', '.') + " " + r.GetUnit + " " + r.Ingredient.Name);
                return sb.ToString();
            }
        }
        public string Status => IsArchived ? "Inactive" : "Active";
    }
}
