using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Services;
using Newtonsoft.Json;

namespace WeatherApp.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherAPIService _weatherAPIService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherAPIService weatherAPIService)
    {
        this._logger = logger;
        this._weatherAPIService = weatherAPIService;
    }
    // GET: api/WeatherForecast
    [HttpGet("{location}")]
    public async Task<ActionResult> GetForecast(String location)
    {
        var response = await _weatherAPIService.GetForecastAsync(location);


        if (response == null)
        {
            return BadRequest();
        }

        var dailyForecasts = _weatherAPIService.PrepareDailyForecast(response);


        string dailyForecastsJson = JsonConvert.SerializeObject(dailyForecasts);



        return Ok(dailyForecastsJson);




    }

}

