
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
    public class WeatherApiService : IWeatherApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public WeatherApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        /// <summary>method <c>GetForecastAsync</c> 
        /// makes external API call to 'WeatherAPI' to retrieve weather data for a given location.
        /// </summary>
        /// <param name="location"> the location to retrieve weather data for. </param>
        /// <returns> A WeatherApiCall object, containing all weather data retrieved </returns>
        public async Task<WeatherApiCall?> GetForecastAsync(string location)
        {
            string url = "http://api.weatherapi.com/v1/forecast.json?key=4ef2b4491aa441a283b183804221702&q="
                + location + "&days=3&aqi=no&alerts=no";


            var httpClient = _httpClientFactory.CreateClient();
            var httpResponse = await httpClient.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
            {
                return null;
            }
            var json = await httpResponse.Content.ReadAsStringAsync();

            var weatherApiResponse = JsonConvert.DeserializeObject<WeatherApiCall>(json);

            return weatherApiResponse;

        }

        /// <summary>
        /// Method <c> PrepareDailyForecast </c> which produces a list of DailyForecast from a WeatherApiCall
        /// 
        /// 
        /// </summary>
        /// <param name="response"> A WeatherAPI object containing forecast data
        /// to extract daily forecasts from </param>
        /// <returns> A list of DailyForecast's</returns>
        public List<DailyForecast> PrepareDailyForecast(WeatherApiCall response)
        {
            
            var dailyForecasts = new List<DailyForecast>();
            if (response != null) {
                var forecastdays = response.Forecast.Forecastday;

                foreach (ForecastDay forecastDay in forecastdays)
                {
                    DailyForecast dailyForecast = new DailyForecast(forecastDay.Date, forecastDay.Day);
                    dailyForecasts.Add(dailyForecast);
                }

                return dailyForecasts;
            }
            return dailyForecasts;



        }

    }
}
