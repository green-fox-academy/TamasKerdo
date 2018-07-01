using Microsoft.AspNetCore.Mvc;
using TripChat.Services;


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