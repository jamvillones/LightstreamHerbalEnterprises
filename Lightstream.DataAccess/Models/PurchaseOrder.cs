using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    [Table(nameof(PurchaseOrder))]
    public partial class PurchaseOrder : IIDModel, IArchivable
    {
        public int Id { get; set; }
        public bool IsArchived { get; set; } = false;
        public DateTime DateOrdered { get; private set; } = DateTime.Now;
        public int Qty { get; set; }
        public decimal Cost { get; set; }

        public Supplier? Supplier { get; set; } = null;
        public Ingredient Ingredient { get; set; } = null!;

    }
}
