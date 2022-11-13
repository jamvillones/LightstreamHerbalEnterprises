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
                        .Include(p=>p.UnitQty)
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
        public override async Task<Product?> Update_Async(Product product)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    var ptemp = await cont.Products
                        .Include(p => p.ProductVariants)
                        .AsNoTracking()
                        .FirstOrDefaultAsync(x => x.Id == product.Id);

                    foreach (var v in ptemp.ProductVariants)
                    {
                        if (!product.ProductVariants.Any(x => x.Id == v.Id))
                        {
                            cont.Entry(v).State = EntityState.Modified;
                            v.IsArchived = true;
                        }
                    }

                    foreach (var v in product.ProductVariants)
                        cont.Entry(v).State = v.Id == 0 ?
                             EntityState.Added : EntityState.Modified;

                    cont.Entry(product).State = EntityState.Modified;

                    await cont.SaveChangesAsync();

                    return product;
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
