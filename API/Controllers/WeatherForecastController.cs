using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    // Square brackets contain attributes.
    [ApiController] // 
    [Route("[controller]")] // The "[controller]" placeholder builds a route named 'WeatherForecase'
    public class WeatherForecastController : ControllerBase  // We don't return views from an API controller.
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]   // Here is an endpoint. When we set a GET request to the WF controller, this method runs.
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();

             // this weatherforecast class is defined in the API folder (one directory above). 
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast 
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
