namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represnt a complete weather forecast retrieved as part 
    /// of a WeatherAPI call
    /// </summary>
    public class WeatherForecast
    {
        public ForecastDay[] Forecastday { get; set; }

    }
}
