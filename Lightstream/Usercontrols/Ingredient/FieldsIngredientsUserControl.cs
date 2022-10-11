using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Usercontrols.IngredientForm
{
    public partial class FieldsIngredientsUserControl : UserControl
    {
        public FieldsIngredientsUserControl()
        {
            InitializeComponent();
        }

        public string IngredientName
        {
            get => nameTxt.Text.Trim();
            set => nameTxt.Text = value;
        }
        public Unit UnitOfMeasurement => (Unit)unitOption.SelectedItem;
        public decimal Cost { get => cost.Value; set => cost.Value = value; }

        private void FieldsIngredientsUserControl_Load(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var units = context.Units.OrderBy(x => x.Name).ToArray();
                unitOption.Items.AddRange(units);
                unitOption.AutoCompleteCustomSource.AddRange(units.Select(x => x.Name).ToArray());
            }
        }
    }
}
