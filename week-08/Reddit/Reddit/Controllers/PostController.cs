using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Repositories;
using Reddit.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Reddit.Controllers
{
    [Route("posts")]
    public class PostController : Controller
    {
        public Repository Repo { get; set; }

        public PostController(Repository Repository)
        {
            Repo = Repository;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View(Repo.getAllThePosts());
        }

        [Route("ListTheBests")]
        public IActionResult ListTheBests()
        {
            var list = new List<Post>();
            list = Repo.ListTheBests();
            //return View("Index",Repo.getAllThePosts());
            return PartialView("~/Views/Post/Index.cshtml", list);
            //PartialView("~/Views/Student/_DeleteStudent.cshtml", model);
        }

        [HttpPost("/posts/{name}")]
        public IActionResult AddPost(Post newPost)
        {
            return Redirect("/");
        }

        [HttpGet("/add")]
        public IActionResult Add()
        {            
            return View("Add");
        }

        [HttpPost("/addNewPost")]
        public IActionResult AddNewPost(string name)
        {
            Repo.CreateNewPost(name);
            return RedirectToAction("Index");
        }

        [HttpGet("/IncreaseOpinion/{PostId}")]
        public IActionResult Decrease(long PostId)
        {
            Repo.IncrementPostId(true, PostId);
            return RedirectToAction("Index");
        }

        [HttpGet("/DecreaseOpinion/{PostId}")]
        public IActionResult Opinion(long PostId)
        {
            Repo.IncrementPostId(false, PostId);
            return RedirectToAction("Index");
        }

       
    }
}
