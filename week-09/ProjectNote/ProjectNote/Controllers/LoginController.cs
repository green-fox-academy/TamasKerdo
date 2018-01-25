using Microsoft.AspNetCore.Mvc;
using ProjectNote.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectNote.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        public Repository repository { get; set; }

        public LoginController(Repository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return Content("Welcome at the loginpage!");
        }
        [HttpPost("CreateUser")]
        public IActionResult CreateUser([FromQuery] string name,[FromQuery] string password,[FromQuery] string greenfoxClass)
        {
            repository.AddNewUser(name, password, greenfoxClass);
            return View();
        }

        [HttpGet("VerifyPassword")]
        public IActionResult VerifyPassword([FromQuery] string name, [FromQuery] string password)
        {
            if (repository.Verify(name, password))
            {
                long? id = repository.GetUser(name, password);
                return RedirectToAction("Index", "Home",new {id = id });
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
