using System;

namespace WebApplication14.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string MyHeaderKey { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
            MyHeaderKey = Guid.NewGuid().ToString();
        }
    }
}
