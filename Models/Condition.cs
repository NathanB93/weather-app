namespace WeatherApp.Models
{
    /// <summary>
    /// A class representing the weather condition object within the JSON response of a WeatherAPI call
    /// </summary>
    public class Condition
    {
        public string text { get; set; }
        public string icon { get; set; }
        public int code { get; set; }
    }
}
