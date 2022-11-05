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
    public partial class UnitMangmtForm : Form
    {
        public UnitMangmtForm()
        {
            InitializeComponent();

        }

        private void _UMTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _Add_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void _Update_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.ShowDialog();
        }
    }
}
