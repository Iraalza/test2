using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class Controller2 : ControllerBase
    {

        private readonly ILogger<Controller2> _logger;

        public Controller2(ILogger<Controller2> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetModel2")]
        public IEnumerable<Model2> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Model2
            {
                Id = Random.Shared.Next(10),
                Age = Random.Shared.Next(100),
            })
            .ToArray();
        }
    }
}
