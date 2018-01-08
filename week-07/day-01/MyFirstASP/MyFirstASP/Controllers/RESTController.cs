using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Greeting()
        {
            var v = new { id = 1, content = "Hello,World" };
            return new JsonResult(v);
        }
    }
}

