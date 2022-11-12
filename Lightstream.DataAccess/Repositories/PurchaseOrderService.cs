using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public class PurchaseOrderService : GenericRepository<PurchaseOrder>
    {
        public async override Task<IEnumerable<PurchaseOrder>> GetAll_Async()
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    return await context.PurchaseOrders
                        .OrderByDescending(x => x.Id)
                        .Include(x => x.Ingredient)
                        .Include(x => x.Supplier)
                        .ToListAsync();
                }

            }
            catch
            {

            }

            return Enumerable.Empty<PurchaseOrder>();
        }
    }
}
