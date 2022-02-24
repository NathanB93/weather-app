namespace WeatherApp.Models
{
    /// <summary>
    /// A class to hold a days weather forecast.
    /// <summary/>
    public class Day
    {
        public double maxtemp_c { get; set; }

        public double Maxtemp_f { get; set; }

        public double mintemp_c { get; set; }

        public double mintemp_f { get; set; }

        public double avgtemp_c { get; set; }

        public double avgtemp_f { get; set; }

        public double maxwind_mph { get; set; }

        public double maxwind_kph { get; set; }

        public double totalprecip_mm { get; set; }
        public double totalprecip_in { get; set; }

        public int daily_chance_of_rain { get; set; }

        public Condition condition { get; set; }










    }
}
