using Lightstream.DataAccess.Data;
using Lightstream.DataAccess.Models;
using Lightstream.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightstream.Forms
{
    
    public partial class save_audit
    {
        protected readonly DbContextFactory _factory = new();
        GenericRepository<AuditTrail> _ingService;
        public save_audit(GenericRepository<AuditTrail> ingService)
        {
            

            _ingService = ingService;
            //_unitService = unitService;
           // ReferencedIngredient = ingredient;
        }
        public async void save_trailAsync(string utype, string uname, string uaction)
        {
            /// create new audit trail
            var auditTrail = new AuditTrail()
            {
                
                Usertype = utype,
                Username = uname,
                UserAction = uaction
            };

            await _ingService.Add_Async(auditTrail);
        }
    }
}
