using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Login
    {
        public Login()
        {
            Transactons = new HashSet<Sale>();
            ProductionHistories = new HashSet<ProductionHistory>();
        }
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName { get; private set; } = null!;
        public int UserType { get; set; } = 0;

        public DateTime DateTimeRegistered { get; set; } = DateTime.MinValue;
        public ICollection<Sale> Transactons { get; set; }
        public ICollection<ProductionHistory> ProductionHistories { get; set; }
    }
}
