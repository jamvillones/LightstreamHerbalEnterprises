using System;
using System.Collections.Generic;

namespace LightstreamHerbalEnterprise.Models
{
    public partial class Product
    {
        public Product()
        {
            MaterialProducts = new HashSet<MaterialProduct>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<MaterialProduct> MaterialProducts { get; set; }
    }
}
