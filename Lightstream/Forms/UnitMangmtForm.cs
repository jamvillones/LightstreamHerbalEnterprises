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
            get => _UMtable.SelectedRows[0].DataBoundItem as Unit;

            set
            {
                unit[_UMitsTable.SelectedRows[0].Index] = value;
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

        }
        //gawa datagrid dataloader
        //para makuha data sa database 
        private void getUnitMngmt()
        {
            _UMTable.AutoGenerateColumns = false;
            //_UMTable.DataSource = 
           
        }

        private void _UMTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _Add_Click(object sender, EventArgs e)
        {
            frmAdd add = new frmAdd();
            add.ShowDialog();
        }

        private void _Update_Click(object sender, EventArgs e)
        {
            frmUpdate update = new frmUpdate();
            update.ShowDialog();
        }
    }
}
