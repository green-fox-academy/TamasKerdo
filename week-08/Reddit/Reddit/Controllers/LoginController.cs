using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    public class LoginController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {

            return View("Index");
        }

        [HttpPost("")]
        public IActionResult Login(string name)
        {
            if (name == "login")
            {                
                return Redirect("/posts");
            }
            else
            {
                return Redirect("/");
            }
            
        }
    }
}
