using EFCore.Practice.Domain.Models;
using EFCore.Practice.Domain.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Practice.DataAccess.Services
{
    public class GenericDataService<T> : IDataService<T> where T : DomainObject
    {
        private readonly DBContextFactory _dbContextFactory;

        public GenericDataService(DBContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<T> AddAsync(T entity)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                var e = await context.Set<T>().AddAsync(entity);
                await context.SaveChangesAsync();

                return e.Entity;
            }
        }
        public async Task<bool> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    await context.Set<T>().AddRangeAsync(entities.ToArray<T>());
                    await context.SaveChangesAsync();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    var toDelete = await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);

                    if (toDelete is not null)
                        context.Set<T>().Remove(toDelete);

                    await context.SaveChangesAsync();
                }
            }
            catch
            {
                return false;
            }

            return true;
        }
        public async Task<bool> RemoveRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    context.RemoveRange(entities.ToArray<T>());

                    await context.SaveChangesAsync();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<T> GetAsync(int id)
        {
            try
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    return await context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    return await context.Set<T>().ToListAsync();
                }
            }
            catch
            {
                return Enumerable.Empty<T>();
            }
        }

        public async Task<T> UpdateAsync(int id, T entity)
        {
            try
            {
                await Task.Run(() =>
                {
                    using (var context = _dbContextFactory.CreateDbContext())
                    {
                        entity.Id = id;
                        context.Set<T>().Update(entity);
                        return entity;
                    }
                });
            }
            catch
            {
            }

            return null;
        }

    }
}
