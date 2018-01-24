using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return Ok();
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
            return Ok();
        }
    }
}
