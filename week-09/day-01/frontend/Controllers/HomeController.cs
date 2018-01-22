using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace frontend.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input == null)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Content("Please provide an input!");
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery] string name, [FromQuery] string title)
        {
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!"});        
        }
    }
}
