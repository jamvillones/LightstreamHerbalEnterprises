using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.CustomControls
{
    internal class NumericUpDownNoArrows : NumericUpDown
    {
        public NumericUpDownNoArrows()
        {
            Controls[0].Hide();
        }
        protected override void OnTextBoxResize(object source, EventArgs e)
        {
            Controls[1].Width = Width - 4;
        }
    }
}
