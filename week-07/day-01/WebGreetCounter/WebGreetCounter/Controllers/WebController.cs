using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebGreetCounter.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebGreetCounter.Controllers
{    

    [Route("web")]
    public class WebController : Controller
    {
        public static int Counter { get; set; }

        // GET: /<controller>/
        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting();
            greeting.Content = "Hello"+ name;
            greeting.Id = Counter;
            Counter++;

            return new JsonResult(greeting);
        }
    }
}
