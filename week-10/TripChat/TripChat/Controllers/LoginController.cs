using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripChat.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripChat.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        public LoginService LoginService { get; set; }

        public LoginController(LoginService loginService)
        {
            LoginService = loginService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("createNew")]
        public IActionResult CreateNew([FromQuery] string userName)
        {
            long? userId = LoginService.CreateNewUser(userName);
            if (userId != null)
                return RedirectToAction("Index","Home", new { userId = userId });
            return RedirectToAction("Index");
        }

        [HttpGet("login")]
        public IActionResult Login([FromQuery] string userName)
        {
            long? userId = LoginService.CheckUser(userName);
            if (userId != null)
                return RedirectToAction("Index", "Home", new { userId = userId });
            return RedirectToAction("Index");
        }
    }
}