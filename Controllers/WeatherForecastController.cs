using GenericRepoPattern.GenericRepository;
using GenericRepoPattern.Modal;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepoPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IRepository<Employee> repoEmployee;
        private IRepository<Departments> repoDepartment;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IRepository<Employee> repoEmployee, IRepository<Departments> repoDepartment)
        {
            _logger = logger;
            this.repoEmployee = repoEmployee;
            this.repoDepartment = repoDepartment;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}