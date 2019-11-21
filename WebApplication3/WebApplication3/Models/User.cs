using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string MyHeaderKey { get; set; }

        public User()
        {
            MyHeaderKey = Guid.NewGuid().ToString();
        }

    }
}
