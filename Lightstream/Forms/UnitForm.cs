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
    public partial class UnitForm : Form
    {
        DbContextFactory factory = new DbContextFactory();
        public Unit ResultingUnit { get; private set; } = null!;
        public UnitForm()
        {
            InitializeComponent();
        }

        public UnitForm(string singularName, string pluralName = "", string abbreviation = "")
        {
            InitializeComponent();

            _singular.Text = singularName;
            _plural.Text = pluralName;
            _abbreviation.Text = abbreviation;
        }

        bool ValidationSuccessful()
        {
            if (string.IsNullOrWhiteSpace(singularLabel.Text.Trim()))
            {
                MessageBox.Show("Singular name cannot empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (MessageBox.Show("Are you sure you want to register " + _singular.Text.Trim() + "?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                return false;
            return true;
        }

        bool SaveUnit()
        {
            try
            {
                using (var context = factory.CreateDbContext())
                {
                    var newUnit = new Unit()
                    {
                        SingularName = _singular.Text.Trim(),
                        PluralName = _plural.Text.Trim(),
                        Abbreviation = _abbreviation.Text.Trim()
                    };
                    context.Units.Add(newUnit);
                    context.SaveChanges();

                    ResultingUnit = newUnit;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _save_Click(object sender, EventArgs e)
        {
            if (ValidationSuccessful())
                if (SaveUnit())
                    DialogResult = DialogResult.OK;
        }
    }
}
