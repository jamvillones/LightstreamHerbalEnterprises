using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public class LHEContext : DbContext
    {
        public LHEContext(DbContextOptions options) : base(options) { }

        public DbSet<Login> Logins { get; set; }
    }
}
