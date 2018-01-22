using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace frontend.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult doubling([FromQuery] int input)
        {
            if (input != 0)
            {
                return Json(new { received = input, result = input * 2 });
            }
            return Content("Please provide an input!");
        }
    }
}
