namespace WeatherApp.Models
{
    /// <summary>
    ///  A class to represent the current weather forecast returned by a WeatherAPi call 
    /// </summary>
    public class CurrentWeather
    {
        public Condition condition { get; set; }
        public string uv { get; set; }

    }
}
