using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UpdatedToDo.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UpdatedToDo.Controllers
{
    public class HomeController : Controller
    {
        public Repository Repository { get; set; }

        public HomeController(Repository Repository)
        {
            this.Repository = Repository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
