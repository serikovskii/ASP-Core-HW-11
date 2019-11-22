using Microsoft.EntityFrameworkCore;
using WebApplication14.Models;

namespace WebApplication14.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options):base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Login = "admin",
                    Password = "1234",
                    Email = "admin@admin.kz",
                    Name = "Azat"
                });
        }
    }

}
