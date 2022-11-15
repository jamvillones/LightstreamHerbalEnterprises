using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public class SaleService : GenericRepository<Sale>
    {
        public async override Task<Sale?> Add_Async(Sale model)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {

                    foreach (var i in model.SoldProducts)
                        context.Entry(i).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                    foreach (var i in model.PaymentRecords)
                        context.Entry(i).State = Microsoft.EntityFrameworkCore.EntityState.Added;

                    var e = context.Entry(model);
                    e.State = Microsoft.EntityFrameworkCore.EntityState.Added;

                    await context.SaveChangesAsync();

                    return e.Entity;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return null;
        }

        public async override Task<IEnumerable<Sale>> GetAll_Async()
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    return await context.Sales
                         .Include(s => s.SoldProducts)
                             .ThenInclude(sp => sp.ProductVariant)
                                 .ThenInclude(pv => pv.Product)
                         .Include(s => s.PaymentRecords)
                         .AsNoTracking()
                         .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Enumerable.Empty<Sale>();
        }
    }
}
