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
    public class ProductionHistoryService : GenericRepository<ProductVariant>
    {
        public async override Task<ProductVariant?> Update_Async(ProductVariant model)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    var ptemp = await cont.ProductVariants
                        .Include(p => p.ProductionHistories)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id == model.Id);

                    foreach (var v in ptemp.ProductionHistories)
                    {
                        if (!model.ProductionHistories.Any(x => x.Id == v.Id))
                        {
                            cont.Entry(v).State = EntityState.Deleted;
                            //v.IsArchived = true;
                        }
                    }

                    foreach (var v in model.ProductionHistories)
                        cont.Entry(v).State = v.Id == 0 ?
                             EntityState.Added : EntityState.Modified;

                    var e = cont.Entry(model);
                    e.State = EntityState.Modified;

                    await cont.SaveChangesAsync();

                    return e.Entity;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return null;
        }
    }
}
