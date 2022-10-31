using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public interface IUpdateRepository<TModel> where TModel : class, IIDModel
    {
        Task<TModel?> Update_Async(TModel model);
    }
}
