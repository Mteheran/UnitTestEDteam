using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Api;
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace tests
{
    public class WeatherForecastTest
    {
        [Fact]
        public void GetWeatherForecast()
        {
            var controller  =  new WeatherForecastController();

            var result  =  controller.Get();

            Assert.NotNull(result);
            Assert.Equal(5,  result.Count());
        }

        [Fact]
        public void GetWeatherForecast_ItemValues()
        {
            var controller  =  new WeatherForecastController();

            var result  =  controller.Get().ToList()[0];

            Assert.NotNull(result);
            Assert.NotEmpty(result.Summary);
            Assert.True(result.TemperatureC > -20);
            Assert.True(result.Date > new DateTime());
        }
        
    }
}