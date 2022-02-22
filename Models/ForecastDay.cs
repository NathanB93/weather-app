namespace WeatherApp.Models
{
    /// <summary>
    /// A class which represents the forecast day object from WeatherAPI call 
    /// </summary>
    public class ForecastDay
    {
        public DateTime date { get; set; }

        public Day day { get; set; }

        public Astro astro { get; set; }

        public Hour[] hour { get; set; }

    }
}
