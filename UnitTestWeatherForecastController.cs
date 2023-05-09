using Microsoft.AspNetCore.Mvc;
using OpenWeather.Model;
using OpenWeatherDemo.Controllers;


namespace TestWeatherDemo
{
    [TestClass]
    public class UnitTestWeatherForecastController
    {
        [TestMethod]
        public async Task GetTestValidCityWeather()
        {
            var controller = new OpenWeatherDemo.Controllers.WeatherForecastController();
            var actionResult = await controller.City("London");
            var result = actionResult as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
        }
        [TestMethod]
        public async Task GetTestInvalidCityWeather()
        {
            var controller = new OpenWeatherDemo.Controllers.WeatherForecastController();
            var actionResult = await controller.City("");
            var result = actionResult as OkObjectResult;
            Assert.IsNull(result);
        }
    }
}