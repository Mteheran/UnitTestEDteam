using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api;
using Microsoft.EntityFrameworkCore;

namespace tests
{
     public static class ApiContextTest
    {
        public static ApiAppContext GetApiAppContext()
        {
            var optiones = new DbContextOptionsBuilder<ApiAppContext>().UseInMemoryDatabase(databaseName: "AppDb").Options;
           
            var dbContext = new ApiAppContext(optiones);
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();

            return dbContext;
        }

        public static ApiAppContext AddInitialData (ApiAppContext context)
        {
            context.Users.Add(new User() { Name = "User Test1", LastName = "User Test2" });
            context.SaveChanges();

            return context;

        }
    }
}