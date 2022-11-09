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
    public partial class SupplierForm : Form
    {
        BindingList<Ingredient> ingredients = new();
        private Supplier? RefSupplier { get; set; }
        public SupplierForm(Supplier refSupplier = null)
        {
            InitializeComponent();
            SetupBindings();
            RefSupplier = refSupplier;
        }

        void SetupBindings()
        {
            _IngredientsTable.AutoGenerateColumns = false;
            Column1.DataPropertyName = nameof(Ingredient.Name);
            _IngredientsTable.DataSource = ingredients;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            if (RefSupplier is null) return;

            _supplierName.Text = RefSupplier.Name;
            _address.Text = RefSupplier.Address;
            _contactnumber.Text = RefSupplier.ContactDetails;
            _contactperson.Text = RefSupplier.ContactPerson;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _supplierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var picker = new IngredientsPicker(new GenericRepository<Ingredient>(),ingredients))
            {
                if (picker.ShowDialog() == DialogResult.OK)
                {
                    var i = picker.Tag as Ingredient;

                    ingredients.Add(i);
                }
            }
        }
    }
}
