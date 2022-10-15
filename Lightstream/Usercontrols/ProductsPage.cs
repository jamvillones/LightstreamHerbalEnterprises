using Lightstream.DataAccess.Models;
using Lightstream.Forms;
using Lightstream.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        BindingList<ProductViewModel> products = new BindingList<ProductViewModel>();
        ProductViewModel SelectedRow => (ProductViewModel)_prodTable.SelectedRows[0].DataBoundItem;
        public ProductsPage()
        {
            InitializeComponent();
            _prodTable.AutoGenerateColumns = false;
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

        private void ProductsPage_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
                products.Add(new ProductViewModel(new Product() { Id = i, Name = "sample product name", Description = "lerom ipsum" }));
            }
            _prodTable.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var p = SelectedRow;

            p.Data.Id = 5487;
            p.Data.Name = "edit this shit!";
            p.Data.Description = "Lerom Ipsum Dolor Amet";
            //= new Product() { Id = 890, Name = "Edit this shit", Description = "Lerom Ipsum" };
            p.UpdateValues();
            
        }
    }
}
