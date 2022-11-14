using Lightstream.DataAccess.Data;
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
    public partial class UnitForm : Form
    {
        //DbContextFactory factory = new DbContextFactory();

        private GenericRepository<Unit> _unitService;
        private Unit? RefUnit;

        public UnitForm(GenericRepository<Unit> service, Unit unit = null)
        {
            InitializeComponent();
            _unitService = service;
            RefUnit = unit;

            if (RefUnit is null) return;

            _singular.Text = unit.SingularName;
            _plural.Text = unit.PluralName;
            _abbreviation.Text = unit.Abbreviation;
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

        async Task<Unit?> SaveUnit()
        {
            var unit = new Unit()
            {
                Id = RefUnit is null ? 0 : RefUnit.Id,
                SingularName = _singular.Text.Trim(),
                Abbreviation = _abbreviation.Text.Trim(),
                PluralName = _plural.Text.Trim()
            };

            return await _unitService.Update_Async(unit);
        }

        private async void _save_Click(object sender, EventArgs e)
        {
            if (!ValidationSuccessful())
                return;

            Tag = await SaveUnit();
            DialogResult = DialogResult.OK;
        }
    }
}
