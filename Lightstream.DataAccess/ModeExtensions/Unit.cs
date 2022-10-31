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
            (string.IsNullOrWhiteSpace(Abbreviation) ? string.Empty : "(" + Abbreviation + ") ") +
            SingularName +
            (string.IsNullOrWhiteSpace(PluralName) ? string.Empty : "/" + PluralName);
    }
}
