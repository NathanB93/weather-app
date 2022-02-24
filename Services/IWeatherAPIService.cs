using System;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface IWeatherApiService
    {
        Task<WeatherApiCall> GetForecastAsync(string location);

        List<DailyForecast> PrepareDailyForecast(WeatherApiCall response);
    }
}
