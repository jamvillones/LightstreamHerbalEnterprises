using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class SupplierToIngredient
    {
        public string IngredientName => Ingredient?.Name;
    }
}
