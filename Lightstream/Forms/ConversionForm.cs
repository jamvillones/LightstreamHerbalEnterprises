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

namespace Lightstream.Forms
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        Unit _from = null, _to = null;
        public Conversion? ResultConversion { get; private set; }
        public ConversionForm(Unit from, Unit to)
        {
            InitializeComponent();
            _from = from;
            _to = to;
        }

        public Unit? FromUnit => _fromOpt.SelectedItem is Unit u ? u : null;
        public Unit? ToUnit => _toOpt.SelectedItem is Unit u ? u : null;

        decimal Value { get; set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var conversion = new Conversion()
                {
                    FromUnitId = FromUnit.Id,
                    ToUnitId = ToUnit.Id,
                    Value = _conversionValue.Value,
                    // BackConvesionValue = _backConversionValue.Value
                };

                context.Conversions.Add(conversion);

                var backConversion = new Conversion()
                {
                    FromUnitId = ToUnit.Id,
                    ToUnitId = FromUnit.Id,
                    Value = _backConversionValue.Value
                };

                context.Conversions.Add(backConversion);

                context.SaveChanges();
                ResultConversion = conversion;
            }

            DialogResult = DialogResult.OK;
        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var units = context.Units;

                _fromOpt.DataSource = units.ToList();
                _toOpt.DataSource = units.ToList();

                var isReadonly = _from is not null && _to is not null;

                _fromOpt.Text = _from.ToString();
                _toOpt.Text = _to.ToString();

                toolTip1.SetToolTip(_conversionValue, "1" + FromUnit.SingularName + " = ?" + ToUnit.SingularName);
                toolTip1.SetToolTip(_backConversionValue, "1" + ToUnit.SingularName + " = ?" + FromUnit.SingularName);

                _fromOpt.Enabled = !isReadonly;
                _toOpt.Enabled = !isReadonly;
            }
        }
    }
}
