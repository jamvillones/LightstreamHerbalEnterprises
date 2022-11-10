using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
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
    public partial class UnitManagementPage : Form
    {
        Unit? SelectedUnit
        {
            get => _unitsTable.SelectedRows[0].DataBoundItem as Unit;
            set => units[_unitsTable.SelectedRows[0].Index] = value;
        }

        /// <summary>
        /// Data that holds the unit displayed in datagridview, should be bound to Datagridview.Datasource
        /// </summary>
        BindingList<Unit> units = new BindingList<Unit>();

        /// <summary>
        /// service for unit manipulation
        /// </summary>
        private GenericRepository<Unit> _unitService;

        public UnitManagementPage(GenericRepository<Unit> unitService)
        {
            InitializeComponent();

            ///set the local variable from the consstructor
            _unitService = unitService;
            ///initialize table column Bindings
            SetDataGridColumnBindings();
        }

        async void UnitMangmtForm_Load(object sender, EventArgs e)
        {
            _unitsTable.DataSource = units;

            await LoadAllUnits();
        }

        private void _Add_Click(object sender, EventArgs e)
        {
            /// use using to dispose the form after it is displayed
            using (var addUnitForm = new UnitForm())
            {
                ///check if the forms DialogResult is Ok
                ///this usually happens when the dialogresult is explicitly set after successful transactions
                ///this means that if the forms transacton is successfully done, dialogresult is set to okay
                if (addUnitForm.ShowDialog() == DialogResult.OK)
                {
                    if (addUnitForm.Tag is Unit u)
                        units.Add(u);
                }
            }
        }

        async Task LoadAllUnits()
        {
            var unit = await _unitService.GetAll_Async();

            this.units.Clear();

            foreach (var i in unit)
                this.units.Add(i);
        }

        void SetDataGridColumnBindings()
        {
            _unitsTable.AutoGenerateColumns = false;

            idCol.DataPropertyName = nameof(Unit.Id);
            abbreviationCol.DataPropertyName = nameof(Unit.Abbreviation);
            nameCol.DataPropertyName = nameof(Unit.SingularName);
            pluralCol.DataPropertyName = nameof(Unit.PluralName);
            statusCol.DataPropertyName = nameof(Unit.Status);
        }

        private void _unitsTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            var table = sender as DataGridView;
            var row = table!.Rows[e.RowIndex];
            var u = units[e.RowIndex];

            table.Rows[e.RowIndex].SetRowColor(u.IsArchived);
        }

        private async void _archive_retrieve_Click(object sender, EventArgs e)
        {
            var su = SelectedUnit;
            if (su == null)
                return;

            await _unitService.ToggleArchive(su);

            _unitsTable.SelectedRows[0].SetRowColor(su.IsArchived);
            _archive_retrieve.SetButtonBehavior(su.IsArchived);
        }

        private void _unitsTable_SelectionChanged(object sender, EventArgs e)
        {
            var su = SelectedUnit;
            if (su is null) return;
            _archive_retrieve.SetButtonBehavior(su.IsArchived);
        }
    }
}
