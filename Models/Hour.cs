namespace WeatherApp.Models
{
    /// <summary>
    /// A class which represents a detailed forecast for a single hour
    /// in a day.
    /// </summary>
    public class Hour
    {
        public DateTime Time { get; set; }

        public double Temp_c { get; set; }

        public double Temp_f { get; set; }

        public int Is_day { get; set; }

        public Condition Condition { get; set; }

        public double Wind_mph { get; set; }

        public double Wind_kph { get; set; }

        public string Wind_dir { get; set; }

        public double Precip_mm { get; set; }

        public double Precip_in { get; set; }

        public int Chance_of_rain { get; set; }

        public double Gust_mph { get; set; }

        public double Gust_kph { get; set; }

    }
}
