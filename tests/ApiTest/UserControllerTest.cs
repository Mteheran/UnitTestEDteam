using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api;
using Xunit;

namespace tests
{
    public class UserControllerTest
    {

        [Fact]
        public void UserGet()
        {
            using var apiContext = ApiContextTest.GetApiAppContext();
            var userController = new UserController(apiContext);

            var result = userController.Get();

            Assert.Equal(3, result.Count());
        }

        
        [Fact]
        public void UserPost()
        {
            using var apiContext = ApiContextTest.GetApiAppContext();
            var userController = new UserController(apiContext);
            User newUser = new User() { Name = "User test", LastName = "User Test"  };

            userController.Post(newUser).Wait();
            var result = userController.Get();

            Assert.Equal(4, result.Count());
            Assert.Equal("User test", result.ToList()[3].Name);
        }

        [Fact]
        public void UserPut()
        {
            using var apiContext = ApiContextTest.GetApiAppContext();
            var userController = new UserController(apiContext); 
          
            var result = userController.Get().ToList()[0];
            result.Name = "User updated";
            userController.Put(result.UserId.ToString(), result);
            var listResult = userController.Get().ToList();

            Assert.Equal(3, listResult.Count());
            Assert.Equal("User updated", listResult.ToList()[0].Name);
        }
        
        
    }
}