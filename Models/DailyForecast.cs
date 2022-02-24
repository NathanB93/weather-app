namespace WeatherApp.Models
{
    /// <summary>
    /// A class to represent forecast data for a given day, holds
    /// the days date and weather info
    /// </summary> 
    public class DailyForecast
    {
        public DailyForecast(DateTime date, Day day) {
            this.Date = date;
            this.Day = day;
        }
        public DateTime Date { get; set; }

        public Day Day { get; set; }
    }
}
