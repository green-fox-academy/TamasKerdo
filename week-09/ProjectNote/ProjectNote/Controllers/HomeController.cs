using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectNote.Models;
using ProjectNote.Repositories;

namespace ProjectNote.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public User user { get; set; }
        public Repository repository { get; set; }

        public HomeController(User user, Repository repository)
        {
            this.user = user;
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
