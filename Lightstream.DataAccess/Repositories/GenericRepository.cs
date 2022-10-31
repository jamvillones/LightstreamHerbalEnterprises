﻿using Lightstream.DataAccess.Data;
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
    public class GenericRepository<TModel> :
        IGetRepository<TModel>
        where TModel : class, IIDModel
    {
        protected readonly DbContextFactory _factory = new();
        public GenericRepository()
        {

        }
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
            try
            {
                using (var cont = _factory.CreateDbContext())
                {
                    var list = await cont.Set<TModel>()
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

            return Enumerable.Empty<TModel>();
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
                    var e = cont.Set<TModel>().AddAsync(m);
                    await cont.SaveChangesAsync();
                    return e.Result.Entity;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return default(TModel);
        }
    }
}
