namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represnt a weather forecast returned by a WeatherAPI call
    /// </summary>
    public class WeatherForecast
    {
        public ForecastDay[] forecastday { get; set; }

    }
}
