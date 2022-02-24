namespace WeatherApp.Models
{
    /// <summary>
    /// A class containg  all forecast data for a single day, including the day's 
    /// date, daily average forecast, astrological data and a detailed hour by hour 
    /// forecast
    /// 
    /// </summary>
    public class ForecastDay
    {
        public DateTime Date { get; set; }

        public Day Day { get; set; }

        public Astro Astro { get; set; }

        public Hour[] Hour { get; set; }

    }
}
