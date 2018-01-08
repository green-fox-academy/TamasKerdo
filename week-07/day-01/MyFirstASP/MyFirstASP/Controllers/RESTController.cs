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
        [Route("api")]
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting();
            
            greeting.Id = 0;
            greeting.Content = "Hello,"+ name;

            return new JsonResult(greeting);
        }
    }
}

