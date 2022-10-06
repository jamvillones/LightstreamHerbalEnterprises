using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public class DbContextFactory: IDesignTimeDbContextFactory<LHEContext>    {
  
        public LHEContext CreateDbContext(string[] args = null)
        {
            var option = new DbContextOptionsBuilder<LHEContext>();
            option.UseSqlServer(
                "Server=MSI\\SQLEXPRESS;" +
                "Database=LHE_DB;" +
                "Trusted_Connection=True;"
                );

            return new LHEContext(option.Options);
        }
    }
}
