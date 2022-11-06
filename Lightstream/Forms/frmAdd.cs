using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
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
    public partial class frmAdd : Form
    {
        private GenericRepository<Unit> _unitService;
        public frmAdd(GenericRepository<Unit>unitService)
        {
            InitializeComponent();
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _save_Click(object sender, EventArgs e)
        {
            UnitMangmtForm f = new UnitMangmtForm();
            f.ShowDialog();
             //wala ka ng gagawin ishoshow mo nalang to
        }
    }
}
