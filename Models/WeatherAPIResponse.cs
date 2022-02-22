namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent a WeatherAPI call response  
    /// </summary>
    public class WeatherAPIResponse
    {
        public Location Location { get; set; }

        public CurrentWeather CurrentWeather { get; set; }

        public WeatherForecast Forecast { get; set; }


    }
}
