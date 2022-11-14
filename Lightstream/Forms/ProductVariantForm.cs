using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    public partial class ProductVariantForm : Form
    {
        private ProductVariant productVariant;
        public ProductVariant? Variant
        {
            get => productVariant;
            private set
            {
                productVariant = value;

                if (productVariant is null)
                    return;

                this.Text = productVariant is not null ? "Edit Variant" : "Add Variant";

                textBox1.Text = productVariant!.Description;
                numericUpDown1.Value = productVariant.Cost;
                numericUpDown2.Value = productVariant.Price;
                numericUpDown4.Value = productVariant.RequiredQty;
            }
        }

        public ProductVariantForm()
        {
            InitializeComponent();
        }
        public ProductVariantForm(ProductVariant variant)
        {
            InitializeComponent();
            Variant = variant;
        }

        public string Description => textBox1.Text.Trim();
        public decimal Price => numericUpDown2.Value;
        public decimal Cost => numericUpDown1.Value;
        public decimal RequiredQty => numericUpDown4.Value;

        private void _save_Click(object sender, EventArgs e)
        {
            if (!CanSave())
                return;

            Save();
        }
        private void Save()
        {
            if (Variant is null)
                productVariant = new();

            Variant!.Description = Description;
            Variant!.Price = Price;
            Variant!.Cost = Cost;
            Variant!.RequiredQty = RequiredQty;

            Tag = productVariant;
            DialogResult = DialogResult.OK;
        }
        bool CanSave()
        {
            if (string.IsNullOrWhiteSpace(Description))
            {
                MessageBox.Show(
                    "Description cannot me empty!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                textBox1.Focus();
                return false;
            }
            return true;
        }
    }
}
