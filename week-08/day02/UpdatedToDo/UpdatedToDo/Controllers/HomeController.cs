using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UpdatedToDo.Repositories;
using UpdatedToDo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UpdatedToDo.Controllers
{
    public class HomeController : Controller
    {
        public Repository Repository { get; set; }
        public List<ToDo> ToDoList { get; set; }

        public HomeController(Repository Repository)
        {
            this.Repository = Repository;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("/Add")]
        public IActionResult Add()
        {            
            return View("Add");
        }

        [HttpPost("/Add")]
        public IActionResult Add(ToDo newtodo)
        {
            Repository.AddNewToDo(newtodo);

            return RedirectToAction("List");
        }

        [HttpGet("List")]
        public IActionResult List()
        {
            return View(Repository.ListAllToDo());
        }

        //[HttpGet("listAll")]
        //public IActionResult List()
        //{
        //    return View(Repository.ListAllToDo());
        //}

        [HttpPost("/listAll")]
        public IActionResult ListAll()
        {            
            return Redirect("listAll");
        }

        //[Route("/listFinished")]
        //public IActionResult List()
        //{
        //    return View("Index");
        //}

        //[Route("/listFinished")]
        //public IActionResult List()
        //{
        //    return View("Index");
        //}

        //[Route("/delete/{id}")]
        //public IActionResult List(int id)
        //{
        //    return View("Index");
        //}

        //[Route("/edit/{id}")]
        //public IActionResult List(int id)
        //{
        //    return View("Index");
        //}
    }
}
