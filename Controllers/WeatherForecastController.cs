using Microsoft.AspNetCore.Mvc;
using my_app.Services;

namespace my_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastAdaptor _weatherForecastAdaptor;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherForecastAdaptor weatherForecastAdaptor)
        {
            _logger = logger;
            _weatherForecastAdaptor = weatherForecastAdaptor;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("getWeather")]
        public async Task GetWeatherForCity(string city)
        {
            string weatherData = await _weatherForecastAdaptor.GetWeatherDataAsync(city);
            Console.WriteLine(weatherData);
        }
    }
}
