using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public sealed partial class Sale : IIDModel
    {
        public Sale()
        {
            SoldProducts = new HashSet<SoldProduct>();
        }
        public int Id { get; set; }
        public DateTime DateTimeTransaction { get; set; } = DateTime.Now;
        public Customer? Customer { get; set; } = null;
        public Login? Login { get; set; }
        public ICollection<SoldProduct> SoldProducts { get; set; } = null!;
        public ICollection<PaymentRecord> PaymentRecords { get; set; } = new HashSet<PaymentRecord>();

    }
}
