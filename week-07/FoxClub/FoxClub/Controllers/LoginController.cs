using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoxClub.Controllers
{
    [Route("login")]
    public class LoginController : Controller
    {
        public Fox MyFox { get; set; }
        
        public LoginController(Fox newFox)
        {
            MyFox = newFox;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(MyFox);
        }

        [HttpPost("")]
        public IActionResult Index(string name)
        {
            MyFox.Name = name;
            return Redirect("/");
        }
    }
}
