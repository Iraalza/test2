using Microsoft.AspNetCore.Mvc;
using test2.Models;

namespace test2.Controllers
{
    [ApiController]
    [Route("controller")]
    public class Controller1 : ControllerBase
    {
        private static readonly string[] Names = new[] { "Ana", "Vasya", "Ira" };

        private readonly ILogger<Controller1> _logger;

        public Controller1(ILogger<Controller1> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetModel1")]
        public IEnumerable<Model1> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Model1
            {
                Date = DateTime.Now.AddDays(index),
                Name = Names[Random.Shared.Next(Names.Length)]
            })
            .ToArray();
        }
    }
}
