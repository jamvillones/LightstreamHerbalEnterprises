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
    public partial class AuditTrailF : Form
    {
        protected readonly DbContextFactory _factory = new();
        public AuditTrailF()
        {
            InitializeComponent();
        }
       

        public void save_trail(string utype, string uname, string uaction)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var audittrail = new AuditTrail()
                    {
                        Usertype = utype,
                        Username = uname,
                        UserAction = uaction,
                        DateTimeRegistered = DateTime.Now
                    };

                    context.AuditTrails.Add(audittrail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "axaxax", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return false;
            }
            //return true;
        }
    }
}
