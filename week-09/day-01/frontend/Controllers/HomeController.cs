using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Microsoft.EntityFrameworkCore;
using Frontend.Entities;
using Frontend.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        public Repository Repo { get; set; }

        public HomeController(Repository repository)
        {
            Repo = repository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            Repo.AddNewLog("api");
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery] int? input)
        {
            if (input == null)
            {                
                Repo.AddNewLog("doubling",input.ToString());
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

            Repo.AddNewLog("greeter", name + " " + title);
            return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
        }

        [HttpGet("appenda/{input}")]
        public IActionResult Appenda([FromRoute] string input)
        {

            Repo.AddNewLog("appenda", input + @"/a/");
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
                Repo.AddNewLog("dountil", input);
                return Json(new { result = sum });
            }
            else if (what == "factor")
            {
                int factorial = 1;
                for (int i = 1; i < input.Until + 1; i++)
                {
                    factorial *= i;
                }
                var newInput = input;
                Repo.AddNewLog("dountil", input);
                return Json(new { result = factorial });
            }

         return Json(new { error = "Please provide a number!" });
        }

        [HttpPost("arrays")]
        public IActionResult ArrayHandler([FromBody] Item input)
        {
           
            if (input.What == "sum")
            {
                int resultToReturn = 0;
                foreach (var element in input.Numbers)
                {
                    resultToReturn += element;
                }
                Repo.AddNewLog("arrays", input);
                return Json(new { result = resultToReturn });
            }
            else if (input.What == "multiply")
            {
                int resultToReturn = 1;
                foreach (var element in input.Numbers)
                {
                    resultToReturn *= element;
                }
                Repo.AddNewLog("arrays", input);
                return Json(new {result = resultToReturn});
            }
            else if (input.What == "double")
            {
                for (int i = 0; i < input.Numbers.Count(); i++)
                {
                    input.Numbers[i] = input.Numbers[i] * 2;
                }
                Repo.AddNewLog("arrays", input);
                return Json(new { result = input.Numbers});
            }

            return Json(new { error = "Please provide what to do with the numbers!" });
        }

        [HttpGet("log")]
        public IActionResult Log()
        {
            return Json(Repo.GetAll());
        }
    }
}
