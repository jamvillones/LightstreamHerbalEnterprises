using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public partial class Unit
    {
        public override string ToString() =>
            SingularName;

        public string Status => IsArchived ? "Inactive" : "Active";

    }
}
