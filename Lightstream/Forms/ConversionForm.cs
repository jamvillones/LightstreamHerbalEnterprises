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

        int FromId_0 => (int)_0_fromOpt.SelectedValue;
        int ToId_0 => (int)_0_ToOpt.SelectedValue;
        int FromId_1 => (int)_1_fromOpt.SelectedValue;
        int ToId_1 => (int)_1_ToOpt.SelectedValue;
        decimal Value { get; set; }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var conversion0 = new Conversion()
                {
                    FromUnitId = FromId_0,
                    ToUnitId = ToId_0,
                    Value = Value
                };

                var conversion1 = new Conversion()
                {
                    FromUnitId = FromId_1,
                    ToUnitId = ToId_1,
                    Value = Value
                };

                context.Conversions.Add(conversion0);
                context.Conversions.Add(conversion1);

                context.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

        private void ConversionForm_Load(object sender, EventArgs e)
        {
            using (var context = new LHE_DBContext())
            {
                var units = context.Units.ToArray();

                _0_fromOpt.DataSource = units.ToList();
                _0_ToOpt.DataSource = units.ToList();

                _1_fromOpt.DataSource = units.ToList();
                _1_ToOpt.DataSource = units.ToList();

                if(_from is not null && _to is not null)
                {
                    _0_fromOpt.Text = _from.Name;
                    _0_ToOpt.Text = _to.Name;

                    _1_fromOpt.Text = _to.Name;
                    _1_ToOpt.Text = _from.Name;

                    _0_fromOpt.Enabled = _0_ToOpt.Enabled = _1_fromOpt.Enabled = _1_ToOpt.Enabled = false;
                }
            }
        }
    }
}
