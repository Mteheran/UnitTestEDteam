using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Api;
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.Extensions.Logging;

namespace tests
{
    public class WeatherForecastTest
    {
        [Fact]
        public void GetWeatherForecast()
        {
            var loggerMock  = new Mock<ILogger<WeatherForecastController>>();
           
            var controller = new WeatherForecastController(loggerMock.Object);

            var result  =  controller.Get();

            Assert.NotNull(result);
            Assert.Equal(5,  result.Count());
        }

        [Fact]
        public void GetWeatherForecast_ItemValues()
        {
            var loggerMock  = new Mock<ILogger<WeatherForecastController>>();

            loggerMock.SetupAllProperties();

            var controller  =  new WeatherForecastController(loggerMock.Object);

            var result  =  controller.Get().ToList()[0];

            Assert.NotNull(result);
            Assert.NotEmpty(result.Summary);
            Assert.True(result.TemperatureC > -20);
            Assert.True(result.Date > new DateTime());
        }
        
    }
}