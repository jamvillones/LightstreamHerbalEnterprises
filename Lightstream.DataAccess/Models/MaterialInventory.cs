using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class MaterialInventory : IIDModel, IArchivable
    {
        public int Id { get; set; }
        public bool IsArchived { get; set; } = false;
        public Ingredient Ingredient { get; set; } = null!;

    }
}
