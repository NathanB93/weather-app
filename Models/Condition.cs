namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent the weather condition data object returned by a WeatherAPI call
    /// </summary>
    public class Condition
    {
        public string Text { get; set; }
        public string Icon { get; set; }
        public int Code { get; set; }
    }
}
