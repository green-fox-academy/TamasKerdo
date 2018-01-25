
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjectNote.Models;
using ProjectNote.Repositories;

namespace ProjectNote.Controllers
{
    [Route("LoggedIn")]
    public class HomeController : Controller
    {
        public Repository repository { get; set; }
        public static long UserId { get; set; }

        public HomeController(Repository repository)
        {
            this.repository = repository;            
        }

        public IActionResult Index(long id)
        {
            UserId = id;
            return Content("Password is verified!");
        }

        [HttpPost("AddNewProject")]
        public IActionResult AddNewProject([FromBody] Project json)
        {
           repository.AddNewProject(json, UserId);

           return Json(new {Status = "New project is added",
                ProjectName = json.Name,
                ProjectLink = json.Link,
                Description = json.Description,
                Language = json.ProgrammingLanguage});
        }

        [HttpGet("Search")]
        public IActionResult Search([FromQuery] string word,
            [FromQuery] bool location, 
            [FromQuery] string language)
        {
            List<ProjectWithoutConnection> ListOfProjects = repository.Search(word, location, language, UserId);                 
            
            return Json(new{ListOfProjects});
        }
    }
}
