using Learn_ASP.NET_Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Learn_ASP.NET_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForcastSevices _weatherForcastSevices;
        public WeatherForecastController(ILogger<WeatherForecastController> logger , IWeatherForcastSevices services)
        {
            _weatherForcastSevices = services;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
           return _weatherForcastSevices.Get();
        }
    }
}
