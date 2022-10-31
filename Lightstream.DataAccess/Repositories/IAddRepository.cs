using Lightstream.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public interface IAddRepository<Tmodel> where Tmodel : class, IIDModel
    {
        Task<Tmodel?> Add_Async(Tmodel entity);
        Task<bool> AddRange_Async(IEnumerable<Tmodel> entities);
    }
}
