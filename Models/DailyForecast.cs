namespace WeatherApp.Models
{
    /// <summary>
    /// A DTO whuch represents a daily weather forecast to be returned to the client 
    /// </summary>
    public class DailyForecast
    {
        public DailyForecast(DateTime date, Day day) {
            this.date = date;
            this.day = day;
        }
        public DateTime date { get; set; }

        public Day day { get; set; }
    }
}
