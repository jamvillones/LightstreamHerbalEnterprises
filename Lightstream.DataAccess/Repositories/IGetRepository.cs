using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public interface IGetRepository<TModel> where TModel : class, IIDModel
    {
        Task<IEnumerable<TModel>> GetAll_Async();
        Task<IEnumerable<TModel>> GetFiltered_Async(
              Func<TModel, bool> filter,
              Range? range = default);
        Task<TModel?> Get_Async(int id);
    }
}
