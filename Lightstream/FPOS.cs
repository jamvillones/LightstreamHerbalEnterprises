using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream
{
    public partial class FPOS : Form, ILogoutForm
    {
        public bool IsLoggedout { get; private set; }= false;

        public FPOS()
        {
            InitializeComponent();
        }

        private void proc_Click(object sender, EventArgs e)
        { 
    
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Logout()
        {
            IsLoggedout = true;
            this.Close();
        }
    }
}
