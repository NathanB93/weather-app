using System;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    public interface IWeatherAPIService
    {
        Task<WeatherAPIResponse> GetForecastAsync(string location);

        List<DailyForecast> PrepareDailyForecast(WeatherAPIResponse response);
    }
}
