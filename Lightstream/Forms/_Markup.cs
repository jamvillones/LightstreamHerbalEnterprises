using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class _Markup : Form
    {
        public _Markup()
        {
            InitializeComponent();
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
