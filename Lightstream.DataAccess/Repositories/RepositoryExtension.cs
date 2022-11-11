using Lightstream.DataAccess.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Repositories
{
    public static class RepositoryExtension
    {
        public static async Task<TModel?> ToggleArchiveAsync<TModel>(this GenericRepository<TModel> service, TModel model) where TModel : class, IIDModel
        {
            if (model is IArchivable archivable)
            {
                archivable.IsArchived = !archivable.IsArchived;
                return await service.Update_Async(model);
            }

            return null;
        }
    }
}
