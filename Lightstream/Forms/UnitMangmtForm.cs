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
    public partial class UnitMangmtForm : Form
    {
        Unit? SeelectedUnit
        {
            get => _unitsTable.SelectedRows[0].DataBoundItem as Unit;

            set
            {
                unit[_unitsTable.SelectedRows[0].Index] = value;
            }
        }
        BindingList<Unit> unit = new BindingList<Unit>();
        bool searchSuccesfull = false;
        private GenericRepository<Unit> _unitService;
        public UnitMangmtForm(GenericRepository<Unit>unitService)
        {
            InitializeComponent();
            _unitService = unitService;
            _unitsTable.AutoGenerateColumns = false;
            SetDataGridColumnBindings();

        }
        //gawa datagrid dataloader
        //para makuha data sa database 
        private void getUnitMngmt()
        {
            _unitsTable.AutoGenerateColumns = false;
            //_UMTable.DataSource = 
           
        }

        private void _UMTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _Add_Click(object sender, EventArgs e)
        {
          
        }

        private void _Update_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.ShowDialog();
        }

        async void UnitMangmtForm_Load(object sender, EventArgs e)
        {
            _unitsTable.DataSource = unit;
            await LoadAllUnits();
        }
        async Task LoadAllUnits()
        {
            var unit = await _unitService.GetAll_Async();

            this.unit.Clear();

            foreach (var i in unit)
                this.unit.Add(i);
        }
        void SetDataGridColumnBindings()
        {
            _unitsTable.AutoGenerateColumns = false;
           _unitName.DataPropertyName = nameof(Unit.SingularName);
        }

    }
}
