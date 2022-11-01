using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public interface IRemoveRepository<TModel> where TModel : class, IIDModel
    {
        Task<bool> Remove_Async(TModel model);
        Task<bool> RemoveRange_Async(IEnumerable<TModel> models);
    }
}
