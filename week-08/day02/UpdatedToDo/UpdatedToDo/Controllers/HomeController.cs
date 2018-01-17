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
            return View("Add",new ToDo());
        }

        [HttpPost("/Add")]
        public IActionResult Add(ToDo newtodo)
        {
            Repository.AddNewToDo(newtodo);
            Repository.ToDoToList = Repository.ListAllToDo();
            return RedirectToAction("List");
        }

        [HttpGet("List")]
        public IActionResult List()
        {            
            return View("List", Repository.ToDoToList);
        }

        [HttpGet("/GetList")]
        public IActionResult GetList()
        {
            Repository.ToDoToList = Repository.ListAllToDo();
            return RedirectToAction("List");
        }

        [HttpGet("/ListFinished")]
        public IActionResult ListFinished()
        {
            Repository.ToDoToList = Repository.ListFinishedToDos();
            return RedirectToAction("List");
        }

        [HttpGet("/ListUnFinished")]
        public IActionResult ListUnFinished()
        {
            Repository.ToDoToList = Repository.ListUnFinishedToDos();
            return RedirectToAction("List");
        }

        [HttpPost("/Delete/{id}")]
        public IActionResult List(int id)
        {
            Repository.DeleteToDo(id);
            return RedirectToAction("GetList");
        }

        [HttpPost("/Edit/{id}")]
        public IActionResult Edit([FromQuery] int id)
        {
            ToDo newTodo = new ToDo();
            newTodo.Id = id;
            return View("Edit",newTodo);
        }

        [HttpPost("/Edit/{id}")]
        public IActionResult EditIt(ToDo newTodo,[FromRoute] int id)
        {
            newTodo.Id = id;
            Repository.EditToDo(newTodo);
            return RedirectToAction("GetList");
        }
    }
}
