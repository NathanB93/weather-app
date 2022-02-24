namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent the data retrieved by a WeatherAPI call.   
    /// </summary>
    public class WeatherApiCall
    {
        public Location Location { get; set; }

        public CurrentWeather CurrentWeather { get; set; }

        public WeatherForecast Forecast { get; set; }


    }
}
