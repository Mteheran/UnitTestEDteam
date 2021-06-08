using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library;
using Xunit;

namespace tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void GetMessageHelloWorld()
        {
            HelloWorld hello = new HelloWorld();
            string result = "";

            result = hello.GetHelloWorld();
            
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            Assert.Contains("Hello World!", result);
        }

        [Fact]
        public void GetMessageHelloWorld_Ends()
        {
            HelloWorld hello = new HelloWorld();
            string result = "";

            result = hello.GetHelloWorld();
            
            Assert.EndsWith("World!!!!", result);
        }

        [Fact]
        public void EsMayordeEdad_True()
        {
            HelloWorld hello = new HelloWorld();
            bool result = false;

            result = hello.EsMayorDeEdad(20);

            Assert.True(result);

        }

        [Fact]
        public void EsMayordeEdad_False()
        {
            HelloWorld hello = new HelloWorld();
            bool result = false;

            result = hello.EsMayorDeEdad(15);

            Assert.False(result);

        }
    }
}