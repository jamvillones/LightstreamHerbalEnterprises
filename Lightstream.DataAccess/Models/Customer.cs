using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class Customer : BaseEntityModel
    {
        public string? ContactDetails { get; set; }
        public string? Address { get; set; }
        public ICollection<Sale> Transactions { get; set; }
    }
}
