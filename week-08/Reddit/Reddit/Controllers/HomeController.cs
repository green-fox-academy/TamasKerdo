using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    public class HomeController : Controller
    {
        public Repository Repo { get; set; }

        public HomeController(Repository Repository)
        {
            Repo = Repository;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
