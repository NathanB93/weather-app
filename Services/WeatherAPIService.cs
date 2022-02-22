
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
    /// <summary>
    /// This class is a service providing methods for making external API calls to 
    /// WeatherAPI, as well as assosciated processes.  
    /// </summary>
    public class WeatherAPIService : IWeatherAPIService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherAPIService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        /// <summary>
        /// Method calls WeatherAPI for a given location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public async Task<WeatherAPIResponse?> GetForecastAsync(string location)
        {
            string url = "http://api.weatherapi.com/v1/forecast.json?key=4ef2b4491aa441a283b183804221702&q="
                + location + "&days=5&aqi=no&alerts=no";


            var httpClient = _httpClientFactory.CreateClient();
            var httpResponse = await httpClient.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            var json = await httpResponse.Content.ReadAsStringAsync();

            var weatherApiResponse = JsonConvert.DeserializeObject<WeatherAPIResponse>(json);

            return weatherApiResponse;

        }

        /// <summary>
        /// Method which produces a list of DailyForecast from a WeatherAPIResponse
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public List<DailyForecast> PrepareDailyForecast(WeatherAPIResponse response)
        {
            var dailyForecasts = new List<DailyForecast>();

            var forecastdays = response.Forecast.forecastday;

            foreach (ForecastDay forecastDay in forecastdays)
            {
                DailyForecast dailyForecast = new DailyForecast(forecastDay.date, forecastDay.day);
                dailyForecasts.Add(dailyForecast);
            }

            return dailyForecasts;

        }

    }
}
