namespace WeatherApp.Models
{
    /// <summary>
    ///  A class to represent the current weather data returned by a WeatherAPi call 
    /// </summary>
    public class CurrentWeather
    {
        public Condition Condition { get; set; }
        public string Uv { get; set; }

    }
}
