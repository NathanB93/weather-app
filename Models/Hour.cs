namespace WeatherApp.Models
{
    /// <summary>
    /// A class which represents an hourly weather forecast.
    /// </summary>
    public class Hour
    {
        public DateTime time { get; set; }

        public double temp_c { get; set; }

        public double temp_f { get; set; }

        public int is_day { get; set; }

        public Condition condition { get; set; }

        public double wind_mph { get; set; }

        public double wind_kph { get; set; }

        public string wind_dir { get; set; }

        public double precip_mm { get; set; }

        public double precip_in { get; set; }

        public int chance_of_rain { get; set; }

        public double gust_mph { get; set; }

        public double gust_kph { get; set; }

    }
}
