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
    public sealed class Ingredient_Supplier_Service : GenericRepository<Ingredient>
    {
        public async override Task<IEnumerable<Ingredient>> GetAll_Async()
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    return await context.Ingredients
                        .Include(i => i.SupplierToIngredients)
                            .ThenInclude(i => i.Supplier)
                        .AsNoTracking()
                        .ToListAsync();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Enumerable.Empty<Ingredient>();
        }
    }
}
