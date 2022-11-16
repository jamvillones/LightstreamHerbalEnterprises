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
    public class CartService : GenericRepository<ProductVariant>
    {
        public async override Task<IEnumerable<ProductVariant>> GetAll_Async()
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    return await context.ProductVariants
                         .Include(x => x.Product)
                         .Include(x => x.ProductionHistories)
                         .Include(x => x.SoldProducts)
                         .AsNoTracking()
                         .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Enumerable.Empty<ProductVariant>();
        }
    }
}
