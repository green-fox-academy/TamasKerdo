using Microsoft.AspNetCore.Mvc;
using MyFirstASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.Controllers
{
    public class RESTController : Controller
    {
        public static int counter { get; set; } = 0;

        [Route("api")]
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        [Route("greeting")]
        public IActionResult Greting([FromQuery] string name)
        {
            var greeting = new Greeting();
            greeting.Id = counter;
            counter++;
            greeting.Content = "Hello," + name;
            return new JsonResult(greeting);
        }
    }
}

