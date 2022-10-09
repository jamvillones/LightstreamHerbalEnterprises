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
        public string UnitOfMeasurement { get => unitofMeasuremenTxt.Text.Trim(); set => unitofMeasuremenTxt.Text = value; }
        public decimal Cost { get => cost.Value; set => cost.Value = value; }
    }
}
