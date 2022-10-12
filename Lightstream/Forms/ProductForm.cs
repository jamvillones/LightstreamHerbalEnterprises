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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void addIngBtn_Click(object sender, EventArgs e)
        {
            using(var recimeForm = new RecipeForm())
            {
                if(recimeForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
