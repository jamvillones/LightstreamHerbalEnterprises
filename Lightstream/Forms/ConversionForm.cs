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
        public ConversionForm(Unit from, Unit to)
        {
            InitializeComponent();
            _from = from;
            _to = to;
        }

        int FromId_0 => (int)_convertFromOpt.SelectedValue;
        int ToId_0 => (int)_convertToOpt.SelectedValue;
        int FromId_1 => (int)_convertBackfromOpt.SelectedValue;
        int ToId_1 => (int)_convertBackToOpt.SelectedValue;
        decimal Value { get; set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var convert = new Conversion()
                {
                    FromUnitId = FromId_0,
                    ToUnitId = ToId_0,
                    Value = Value
                };

                var convertBack = new Conversion()
                {
                    FromUnitId = FromId_1,
                    ToUnitId = ToId_1,
                    Value = Value
                };

                context.Conversions.Add(convert);
                context.Conversions.Add(convertBack);
                context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var units = context.Units.ToArray();

                _convertFromOpt.DataSource = units.ToList();
                _convertToOpt.DataSource = units.ToList();

                _convertBackfromOpt.DataSource = units.ToList();
                _convertBackToOpt.DataSource = units.ToList();

                if(_from is not null && _to is not null)
                {
                    _convertFromOpt.Text = _from.SingularName;
                    _convertToOpt.Text = _to.SingularName;

                    _convertBackfromOpt.Text = _to.SingularName;
                    _convertBackToOpt.Text = _from.SingularName;

                    _convertFromOpt.Enabled = _convertToOpt.Enabled = _convertBackfromOpt.Enabled = _convertBackToOpt.Enabled = false;
                }
            }
        }
    }
}
