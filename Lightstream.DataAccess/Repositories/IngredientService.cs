using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public class IngredientService : GenericRepository<Ingredient>
    {
        public override async Task<IEnumerable<Ingredient>> GetAll_Async()
        {
            using(var context= _factory.CreateDbContext())
            {
                return await context.Ingredients
                                    .Include(i => i.UnitMeasurement)
                                    .Include(i => i.Recipes)
                                        .ThenInclude(r=>r.Product)
                                            .ThenInclude(p=>p.ProductVariants)
                                                .ThenInclude(pv=>pv.ProductionHistories)
                                    .Include(i => i.PurchaseOrders)
                                    .AsNoTracking()
                                    .ToListAsync();
            }
            return Enumerable.Empty<Ingredient>();
        }
    }
}
