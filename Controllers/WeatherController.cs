using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WeatherApp.Services;


namespace WeatherApp.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherAPIService _weatherAPIService;

        public WeatherController(ILogger<WeatherForecastController> logger, IWeatherAPIService weatherAPIService)
        {
            this._logger = logger;
            this._weatherAPIService = weatherAPIService;
        }
        // GET: WeatherForecast
        [HttpGet("{location}")]
        public async Task<ActionResult> GetForecast(String location)
        {
            var response = await _weatherAPIService.GetForecastAsync(location);


            if (response == null)
            {
                return BadRequest();
            }

            var dailyForecasts = _weatherAPIService.PrepareDailyForecast(response);



            return Ok(dailyForecasts);




        }

    }
}
