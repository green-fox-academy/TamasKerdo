using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectNote.Models;
using ProjectNote.Repositories;

namespace ProjectNote.Controllers
{
    [Route("loggedIn")]
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

        public IActionResult AddNewProject([FromQuery] string link, 
            [FromQuery] string projectName, 
            [FromQuery] string description, 
            [FromQuery] string language)
        {
            repository.AddNewProject(link, projectName, description, language);

            return Json(new {Status = "New project is added",
                ProjectName = projectName,
                ProjectLink = link,
                Description = description,
                Language = language});
        }

        public IActionResult Search([FromQuery] string word,
            [FromQuery] bool location, 
            [FromQuery] string language)
        {
            var ListOfProjects = repository.Search(word, location, language);

            return Json(new {ListOfProjects});
        }
    }
}
