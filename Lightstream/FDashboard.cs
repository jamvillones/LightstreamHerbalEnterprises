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

    public partial class FDashboard : Form
    {     
        
        public FDashboard()
        {
            InitializeComponent();
            customizedesign();
        }

        private void customizedesign()
        {
            pnlFiles.Visible = false;
            pnlTrnsctn.Visible = false;
            pnlInvntry.Visible = false;
            pnlSlsSmry.Visible = false;
        }
        private void hideMenu()
        {

            if (pnlFiles.Visible == true)
                pnlFiles.Visible = false;
            if (pnlTrnsctn.Visible == true)
                pnlTrnsctn.Visible = false;
            if (pnlInvntry.Visible == true)
                pnlInvntry.Visible = false;
            if (pnlSlsSmry.Visible == true)
                pnlSlsSmry.Visible = false;

        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnFls_Click(object sender, EventArgs e)
        {
            showMenu(pnlFiles);
        }

        private void btnTrnsctn_Click(object sender, EventArgs e)
        {
            showMenu(pnlTrnsctn);
        }

        private void btnInvntry_Click(object sender, EventArgs e)
        {
            showMenu(pnlInvntry);
        }

        private void bbtnSlsSmry_Click(object sender, EventArgs e)
        {
            showMenu(pnlSlsSmry);
        }

        private void btnPrd_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnUM_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnProdInvtnry_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnRawM_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnMUp_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnSlsSmry_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            hideMenu();
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSOut_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        
    }
}
