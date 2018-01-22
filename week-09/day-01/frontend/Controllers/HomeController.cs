using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using frontend.Models;

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
                return Json(new { recieved = input, result = input * 2 });
            }
            return Content("Please provide an input!");
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery] string name, [FromQuery] string title)
        {
            if (name == null || title == null)
            {
                return Content("Please provide an input!");
            }
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet("appenda/{input}")]
        public IActionResult Appenda([FromRoute] string input)
        {
            return Json(new { appended = input + "a" });
        }

        [HttpGet("appenda")]
        public IActionResult AppendaWithoutParameter()
        {
            var result = new NotFoundObjectResult(new { message = "404 Not Found", currentDate = DateTime.Now });
            return result;
        }

        [HttpPost("dountil/{what}")]
        public IActionResult Dountil([FromRoute] string what, [FromBody] Item input)
        {
            if (input.until !=null)
            {
                switch (what)
                {

                    case "sum":
                        int sum = 0;
                        for (int i = 1; i < input.until+1; i++)
                        {
                            sum += i;
                        }
                        return Json(new { result = sum });
                        
                    case "factor":
                        int factorial = 1;
                        for (int i = 1; i < input.until+1; i++)
                        {
                            factorial *= i;
                        }
                        return Json(new { result = factorial });
                        
                    default:
                        break;
                }
            }
            return Json(new { error = "Please provide a number!" });
        }
    }
}
