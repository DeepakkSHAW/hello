using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Let the battle begin!");
        }

        [HttpPost]
        public string  PostTodoItem(ArenaUpdate arenaUpdate)
        {
            Console.WriteLine(arenaUpdate);
            try
            {
                string[] commands = new string[] { "F", "R", "L", "T" };
                int i = new Random().Next(4);

                return commands[i];
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
