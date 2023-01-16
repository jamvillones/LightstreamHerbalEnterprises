using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class AuditTrail:BaseEntityModel
    { 
        public int Id { get; set; }
        public string Usertype { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string UserAction { get; set; } = null!;
        public DateTime DateTimeRegistered { get; set; } = DateTime.MinValue;

    }

}
