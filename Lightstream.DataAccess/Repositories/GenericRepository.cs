using Lightstream.DataAccess.Data;
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
    public class GenericRepository<TModel> :
        IGetRepository<TModel>,
        IAddRepository<TModel>,
        IUpdateRepository<TModel>,
        IRemoveRepository<TModel>
        where TModel : class, IIDModel
    {
        protected readonly DbContextFactory _factory = new();
        public virtual async Task<IEnumerable<TModel>> GetAll_Async()
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    return await cont.Set<TModel>().ToListAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return Enumerable.Empty<TModel>();
        }

        public virtual async Task<IEnumerable<TModel>> GetFiltered_Async(
            Func<TModel, bool> filter,
            Range? range = default)
        {
            var models = (await GetAll_Async()).Where(filter);

            if (range is not null)
                return models.Take((Range)range);

            return models;
        }
        public virtual async Task<TModel?> Get_Async(int id)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    await cont.Set<TModel>().FirstOrDefaultAsync(ent => ent.Id == id);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return default;
        }

        public virtual async Task<TModel?> Add_Async(TModel m)
        {
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    cont.Update(m);

                    await cont.SaveChangesAsync();
                    return m;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return default(TModel);
        }
        public virtual async Task<bool> AddRange_Async(IEnumerable<TModel> entities)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    await context.Set<TModel>().AddRangeAsync(entities);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public virtual async Task<TModel?> Update_Async(TModel model)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    var e = context.Update(model);

                    await context.SaveChangesAsync();

                    return e.Entity;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return default(TModel);
        }

        public virtual async Task<bool> Remove_Async(TModel model)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    context.Entry(model).State = EntityState.Deleted;
                    //context.Remove(model);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return false;
        }

        public async Task<bool> RemoveRange_Async(IEnumerable<TModel> models)
        {
            try
            {
                using (var context = _factory.CreateDbContext())
                {
                    context.RemoveRange(models.ToArray());
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
