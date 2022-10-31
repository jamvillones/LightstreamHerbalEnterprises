using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public sealed class ProductService : GenericRepository<Product>
    {       
        public override async Task<IEnumerable<Product>> GetAll_Async()
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    return await cont.Products
                        .Include(p => p.UnitQty)
                        .Include(p => p.Recipes)
                            .ThenInclude(r => r.Conversion)
                            .ThenInclude(r => r.FromUnit)
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
        public override async Task<IEnumerable<Product>> GetFiltered_Async(
            Func<Product, bool> filter,
            Range? range = null)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    var list = await cont.Products
                        .Include(p => p.UnitQty)
                        .Include(p => p.Recipes)
                            .ThenInclude(r => r.Conversion)
                            .ThenInclude(r => r.FromUnit)
                        .Include(p => p.Recipes)
                            .ThenInclude(r => r.Ingredient)
                            .ThenInclude(r => r.UnitMeasurement)
                        .AsNoTracking()
                        .ToListAsync();

                    /// apply range is available
                    if (range is not null)
                        return list.Where(filter).Take((Range)range);

                    return list.Where(filter);
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
                    /// using state approach
                    foreach (var r in product.Recipes)
                        context.Entry(r).State = EntityState.Added;

                    context.Entry(product).State = EntityState.Added;

                    /// verbose approach where you have to manually attach references by setting their states
                    //var unit = product.UnitQty;
                    //context.Entry(unit).State = EntityState.Unchanged;
                    //foreach (var r in product.Recipes)
                    //    context.Entry(r).State = EntityState.Added;

                    //var e = await context.Products.AddAsync(product);

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
    }
}
