﻿using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using Lightstream.Extensions;
using Lightstream.Services;
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
            get
            {
                if (_unitsTable.RowCount == 0) return null;
                return _unitsTable.SelectedRows[0].DataBoundItem as Unit;
            }
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

        void UnitMangmtForm_Load(object sender, EventArgs e)
        {
            _unitsTable.DataSource = units;

            //await LoadAllUnits();

            for (int i = 0; i < (int)ArchiveStatus.Count; i++)
            {
                _statusOption.Items.Add((ArchiveStatus)i);
            }

            _statusOption.SelectedIndex = 0;
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

            var filtered = unit.FilterByStatus(_statusOption.SelectedIndex);

            this.units.Clear();
            foreach (var i in filtered.OrderBy(x => x.SingularName))
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

            await _unitService.ToggleArchiveAsync(su);

            _unitsTable.SelectedRows[0].SetRowColor(su.IsArchived);
            _archive_retrieve.SetButtonBehavior(su.IsArchived);
        }

        private void _unitsTable_SelectionChanged(object sender, EventArgs e)
        {
            var su = SelectedUnit;
            if (su is null) return;
            _archive_retrieve.SetButtonBehavior(su.IsArchived);
        }

        bool searchFound = false;

        private async void _search_TextChanged(object sender, EventArgs e)
        {
            if (!searchFound) return;
            if (!string.IsNullOrWhiteSpace(_search.Text)) return;

            await LoadAllUnits();
            searchFound = false;
        }

        private async void _search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var text = _search.Text.ToLower().Trim();
                if (string.IsNullOrWhiteSpace(text))
                    return;

                var units = await _unitService.GetAll_Async();

                units = SearchHandler.FilterList(
                   units,
                   FilteringFlow.StopUponSatisfaction,
                   x => x.SingularName.ToLower().Contains(text),
                   x => x.Abbreviation?.ToLower().Contains(text) ?? false
                   );

                searchFound = units.Count() > 0;
                if (!searchFound)
                {
                    MessageBox.Show("No unit found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.units.Clear();
                foreach (var u in units.OrderBy(x => x.SingularName))
                {
                    this.units.Add(u);
                }
            }
        }

        private async void _statusOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadAllUnits();
        }
    }
}
