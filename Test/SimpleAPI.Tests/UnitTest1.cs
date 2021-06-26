using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        //arrange
        WeatherForecastController wController = new WeatherForecastController();



        [Fact]
        public void Test1()
        {
            //Act
            var output = wController.FetchData(1);

            //Assert
            Assert.Equal("Rashi",output);
        }
    }
}
