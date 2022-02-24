namespace WeatherApp.Models
{
    /// <summary>
    /// A class to hold a days weather forecast.
    /// <summary/>
    public class Day
    {
        public double Maxtemp_c { get; set; }

        public double Maxtemp_f { get; set; }

        public double Mintemp_c { get; set; }

        public double Mintemp_f { get; set; }

        public double Mvgtemp_c { get; set; }

        public double Mvgtemp_f { get; set; }

        public double Maxwind_mph { get; set; }

        public double Maxwind_kph { get; set; }

        public double Totalprecip_mm { get; set; }
        public double Totalprecip_in { get; set; }

        public int Daily_chance_of_rain { get; set; }

        public Condition Condition { get; set; }










    }
}
