using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstASP.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            return Content("Hello World!");
        }

        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello!");
        }
    }
}
