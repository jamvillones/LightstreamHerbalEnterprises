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
    public class ProductVariantService : ProductService
    {
        public override async Task<IEnumerable<Product>> GetAll_Async()
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    return await cont.Products
                        .Include(p => p.ProductVariants)                        
                        .AsNoTracking()
                        .ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return Enumerable.Empty<Product>();
        }
    }
}
