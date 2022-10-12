
using Lightstream.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream
{
    public class DbContextFactory : IDesignTimeDbContextFactory<LHE_DBContext>
    {

        public LHE_DBContext CreateDbContext(string[] args = null)
        {
            var option = new DbContextOptionsBuilder<LHE_DBContext>();
            option.UseSqlServer(
                "Server=DESKTOP-EP1IGTA\\SQLEXPRESS;" +
                "Database=LHE_DB;" +
                "Trusted_Connection=True;"
                );

            return new LHE_DBContext(option.Options);
        }
    }
}
