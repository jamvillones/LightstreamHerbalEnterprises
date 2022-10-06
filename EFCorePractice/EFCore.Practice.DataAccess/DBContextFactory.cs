using EFCore.Practice.DataAccess.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Practice.DataAccess
{
    public class DBContextFactory : IDesignTimeDbContextFactory<POSDbContext>
    {
        public POSDbContext CreateDbContext(string[] args = null)
        {
            var option = new DbContextOptionsBuilder<POSDbContext>();
            option.UseSqlServer("Server=DESKTOP-EP1IGTA\\SQLEXPRESS;Database=EFCOREPracticeDB;Trusted_Connection=True;");

            return new POSDbContext(option.Options);
        }
    }
}
