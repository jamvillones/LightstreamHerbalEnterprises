using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public sealed class SupplierService : GenericRepository<Supplier>
    {
        public override async Task<IEnumerable<Supplier>> GetAll_Async()
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    return await context.Set<Supplier>()
                        .AsNoTracking()
                        .Include(s => s.SupplierToIngredients)
                            .ThenInclude(si => si.Ingredient)
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return Enumerable.Empty<Supplier>();
        }

        public override async Task<Supplier?> Update_Async(Supplier model)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var t = await context.Suppliers.Include(s => s.SupplierToIngredients).AsNoTracking().FirstOrDefaultAsync(x => x.Id == model.Id);

                    foreach (var i in t.SupplierToIngredients)
                    {
                        if (!model.SupplierToIngredients.Any(x => x.Id == i.Id))
                            context.Entry(i).State = EntityState.Deleted;
                    }

                    foreach (var s in model.SupplierToIngredients)
                        if (s.Id == 0)
                            context.Entry(s).State = EntityState.Added;

                    context.Entry(model).State = EntityState.Modified;
                    await context.SaveChangesAsync();
                    return model;
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
