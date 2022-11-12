using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class SupplierToIngredient : IIDModel
    {
        [Required]
        public decimal Cost { get; set; } = 0;
        public Ingredient Ingredient { get; set; }
        public Supplier Supplier { get; set; }
        public int Id { get; set; }
    }
}
