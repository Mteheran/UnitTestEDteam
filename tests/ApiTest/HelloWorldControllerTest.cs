using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api;
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace tests
{
    public class HelloWorldControllerTest
    {
        [Fact]
        public void GetTModels()
        {
            var controller = new HelloWorldController();

            var result = controller.GetTModels();

            Assert.NotNull(result);
            Assert.Equal(2, result.Value.Count());
        }


        [Fact]
        public void GetById()
        {
            var controller = new HelloWorldController();

            var result = controller.GetById(1);

            Assert.Equal("Hello World", result.Value);
        }

        
        [Fact]
        public void GetById_BadRequest()
        {
            var controller = new HelloWorldController();

            var result = controller.GetById(-2);

            Assert.IsType<BadRequestResult>(result.Result);
        }

        [Fact]
        public void GetById_NotFound()
        {
            var controller = new HelloWorldController();

            var result = controller.GetById(0);

            Assert.IsType<NotFoundResult>(result.Result);
        }

        
        [Fact]
        public void Post()
        {
            var controller = new HelloWorldController();

            var result = controller.PostTModel("");

            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void Put()
        {
            var controller = new HelloWorldController();

            var result = controller.PutTModel("");

            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public void Delete()
        {
            var controller = new HelloWorldController();

            var result = controller.DeleteTModelById("");

            Assert.Null(result);
        }
        
    }
}