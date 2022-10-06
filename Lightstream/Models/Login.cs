using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Models
{
    public class Login: DomainObject
    {
        public string Username { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
    }
}
