using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public class ProductService : GenericRepository<Product>
    {
        public override async Task<IEnumerable<Product>> GetAll_Async()
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    return await cont.Products
                        .Include(p => p.ProductVariants)
                            .ThenInclude(pv=>pv.ProductionHistories)
                        .Include(p=>p.ProductVariants)
                            .ThenInclude(pv=>pv.SoldProducts)
                        .Include(p => p.UnitQty)
                        .Include(p => p.Recipes)
                            .ThenInclude(r => r.Ingredient)
                            .ThenInclude(r => r.UnitMeasurement)
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

        public override async Task<Product?> Get_Async(int id)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    var prod = await cont.Products.FirstOrDefaultAsync(p => p.Id == id);

                    if (prod is not null)
                    {
                        await cont.Entry(prod).Collection(p => p.Recipes).LoadAsync();
                        await cont.Entry(prod).Reference(p => p.UnitQty).LoadAsync();
                    }
                    return prod;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return default(Product?);
        }

        public override async Task<Product?> Add_Async(Product product)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    if (product.UnitQty.Id == 0)
                        context.Entry(product.UnitQty).State = EntityState.Added;

                    foreach (var r in product.Recipes)
                        context.Entry(r).State = EntityState.Added;

                    context.Entry(product).State = EntityState.Added;

                    await context.SaveChangesAsync();

                    return product;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return default(Product);
        }

        public override async Task<Product?> Update_Async(Product product)
        {
            using (var context = _factory.CreateDbContext())
            {
                //we get the raw so that we can remove the recipe that is no longer available at the new recipe
                var existingProduct = await context.Products
                    .Include(p => p.Recipes)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id == product.Id);

                //if the existing recipe is not already in the new product. it means it has been removed and should be removed in the database
                foreach (var recipe in existingProduct!.Recipes)
                    if (!product.Recipes.Any(r => r.Id == recipe.Id))
                        context.Entry(recipe).State = EntityState.Deleted;

                foreach (var recipe in product.Recipes)
                    context.Entry(recipe).State = recipe.Id == 0 ? EntityState.Added : EntityState.Modified;

                context.Entry(product.UnitQty).State = EntityState.Unchanged;
                context.Entry(product).State = EntityState.Modified;
                await context.SaveChangesAsync();

                return product;
            }
        }
    }
}
