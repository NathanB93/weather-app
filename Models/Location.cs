namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent the location of a weather forecast.
    /// </summary>
    public class Location
    {
        public string name { get; set; }
        public string region { get; set; }
        public string country { get; set; }
        public double lat { get; set; }

        public double lon { get; set; }
        public string tz_id { get; set; }
        public int localtime_epoch { get; set; }
        public DateTime localtime { get; set; }

    }
}