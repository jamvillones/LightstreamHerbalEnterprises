using System;
using System.Collections.Generic;

namespace LightstreamHerbalEnterprise.Models
{
    public partial class MaterialProduct
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public int ProductId { get; set; }
        public decimal MaterialRequirment { get; set; }
        public string? Detail { get; set; }

        public virtual Material Material { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
