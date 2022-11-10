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
        BindingList<SupplierToIngredient> ingredients = new();
        private Supplier? RefSupplier { get; set; }
        public GenericRepository<Supplier> SupplierService { get; init; }
        public SupplierForm(Supplier refSupplier = null)
        {
            InitializeComponent();
            SetupBindings();
            RefSupplier = refSupplier;
        }

        void SetupBindings()
        {
            idCol.DataPropertyName = nameof(SupplierToIngredient.Id);
            Column1.DataPropertyName = nameof(SupplierToIngredient.IngredientName);

            _IngredientsTable.AutoGenerateColumns = false;
            _IngredientsTable.DataSource = ingredients;
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadValues();
        }

        void LoadValues()
        {
            if (RefSupplier is null) return;

            _supplierName.Text = RefSupplier.Name;
            _address.Text = RefSupplier.Address;
            _contactnumber.Text = RefSupplier.ContactDetails;
            _contactperson.Text = RefSupplier.ContactPerson;

            ingredients.Clear();
            foreach (var i in RefSupplier.SupplierToIngredients)
                ingredients.Add(i);

            ChangesMade = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool _changesMade = false;
        bool ChangesMade
        {
            get => _changesMade; set
            {
                _changesMade = value;
                _save.Enabled = ChangesMade && !string.IsNullOrWhiteSpace(_supplierName.Text);
                _cancel.Enabled = ChangesMade;
            }
        }
        private void _supplierName_TextChanged(object sender, EventArgs e)
        {
            ChangesMade = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var picker = new IngredientsPicker(new GenericRepository<Ingredient>(), ingredients.Select(x => x.Ingredient)))
            {
                if (picker.ShowDialog() == DialogResult.OK)
                {
                    var i = picker.Tag as Ingredient;

                    ingredients.Add(new SupplierToIngredient() { Ingredient = i });
                    ChangesMade = true;
                }
            }
        }

        private async void _save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to save changes?",
                "",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                ) is not DialogResult.OK)
                return;

            var sup = new Supplier()
            {
                Id = RefSupplier.Id,
                Name = _supplierName.Text.Trim(),
                ContactDetails = _contactnumber.Text.Trim(),
                ContactPerson = _contactperson.Text.Trim(),
                Address = _address.Text.Trim(),

                SupplierToIngredients = ingredients.ToList()
            };

            var reslult = await SupplierService.Update_Async(sup);
            if (reslult is not null)
            {
                Tag = reslult;
                ChangesMade = false;
                DialogResult = DialogResult.OK;
            }
        }

        private void _IngredientsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == removeCol.Index)
            {
                ingredients.RemoveAt(e.RowIndex);
                ChangesMade = true;
            }
        }

        private void _cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel changes?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                LoadValues();
        }

        private void SupplierForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesMade)
                e.Cancel = MessageBox.Show("Changes not saved yet. Are you sure you want to exit?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel;
        }

        private void TextChanged(object sender, EventArgs e)
        {
            ChangesMade = true;
        }
    }
}
