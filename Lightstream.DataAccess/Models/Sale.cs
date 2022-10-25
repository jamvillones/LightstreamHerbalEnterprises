using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class Sale
    {
        public Sale()
        {
            SoldItems = new HashSet<SoldProduct>();
        }
        public int Id { get; set; }
        public DateTime DateTimeTransaction { get; set; }
        public Customer Customer { get; set; } = null!;
        public Login? Login { get; set; }
        public ICollection<SoldProduct> SoldItems { get; set; } = null!;

    }
}
