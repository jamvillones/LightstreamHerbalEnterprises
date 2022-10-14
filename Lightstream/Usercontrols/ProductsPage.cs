using Lightstream.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Usercontrols
{
    public partial class ProductsPage : Form
    {
        public ProductsPage()
        {
            InitializeComponent();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            using (var product = new ProductForm())
            {
                if (product.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
