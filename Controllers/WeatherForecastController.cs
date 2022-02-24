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
    private readonly IWeatherApiService _weatherApiService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherApiService weatherAPIService)
    {
        this._logger = logger;
        this._weatherApiService = weatherAPIService;
    }
    // GET: api/WeatherForecast
    [HttpGet("{location}")]
    public async Task<ActionResult> GetForecast(String location)
    {
        var response = await _weatherApiService.GetForecastAsync(location);
        
        var dailyForecasts = _weatherApiService.PrepareDailyForecast(response);

        string dailyForecastsJson = JsonConvert.SerializeObject(dailyForecasts);

        if (response is null)
        {
           
            return BadRequest(dailyForecastsJson);
        }
        
        return Ok(dailyForecastsJson);

    }

}

