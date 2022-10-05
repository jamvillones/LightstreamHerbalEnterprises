using System;
using System.Collections.Generic;

namespace LightstreamHerbalEnterprise.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialProducts = new HashSet<MaterialProduct>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string UnitOfMeasurement { get; set; } = null!;

        public virtual ICollection<MaterialProduct> MaterialProducts { get; set; }
    }
}
