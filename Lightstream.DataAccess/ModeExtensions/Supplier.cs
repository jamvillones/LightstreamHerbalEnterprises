using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    partial class Supplier
    {
        public string Status => IsArchived ? "Inactive" : "Active";
        public override string ToString() => Name;
       
    }
}
