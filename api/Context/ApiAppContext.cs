using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class ApiAppContext : DbContext
    {
        public DbSet<User> Users {get;set;}
        public ApiAppContext(DbContextOptions<ApiAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<User> usersInitData = new List<User>();

            usersInitData.Add(new User{ Name = "User 1", LastName = "LastName 1" });
            usersInitData.Add(new User{ Name = "User 2", LastName = "LastName 2" });
            usersInitData.Add(new User{ Name = "User 3", LastName = "LastName 3" });

            builder.Entity<User>().ToTable("User").HasData(usersInitData);
            builder.Entity<User>().HasKey(p=> p.UserId);
            
        }
        
    }
}