using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectNote.Models;
using ProjectNote.Repositories;

namespace ProjectNote.Controllers
{
    public class HomeController : Controller
    {        
        
        public Repository repository { get; set; }

        public HomeController(Repository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return Content("Password is verified!");
        }
    }
}
