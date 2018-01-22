using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        public  DbContext LC { get; set; }

        public HomeController(DbContext lc)
        {
            LC = lc;
        }

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
            if (what == "sum")
            {
                int sum = 0;
                for (int i = 1; i < input.Until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < input.Until + 1; i++)
                {
                    factorial *= i;
                }
                return Json(new { result = factorial });
            }

         return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("arrays")]
        public IActionResult ArrayHandler([FromBody] Item item)
        {
           
            if (item.What == "sum")
            {
                int resultToReturn = 0;
                foreach (var element in item.Numbers)
                {
                    resultToReturn += element;
                }
                return Json(new { result = resultToReturn });
            }
            else if (item.What == "multiply")
            {
                int resultToReturn = 1;
                foreach (var element in item.Numbers)
                {
                    resultToReturn *= element;
                }
                return Json(new {result = resultToReturn});
            }
            else if (item.What == "double")
            {
                for (int i = 0; i < item.Numbers.Count(); i++)
                {
                    item.Numbers[i] = item.Numbers[i] * 2;
                }
                return Json(new { result = item.Numbers});
            }

            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}
