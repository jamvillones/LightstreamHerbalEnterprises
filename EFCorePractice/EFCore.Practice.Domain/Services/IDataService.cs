using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Practice.Domain.Services
{
    /// <summary>
    /// basic interface for CRUD OPERATION!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);    
        Task<T> AddAsync(T entity);
        Task<bool> AddRangeAsync(IEnumerable<T> entities);       
        Task<T> UpdateAsync(int id,T entity);
        Task<bool> RemoveAsync(int id);
        Task<bool> RemoveRangeAsync(IEnumerable<T> entities);

    }
}
