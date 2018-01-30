using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripChat.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("createNew")]
        public IActionResult CreateNew()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
