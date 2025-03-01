
namespace Learn_ASP.NET_Core.Services
{
    public interface IWeatherForcastSevices
    {
        IEnumerable<WeatherForecast> Get();
    }
}