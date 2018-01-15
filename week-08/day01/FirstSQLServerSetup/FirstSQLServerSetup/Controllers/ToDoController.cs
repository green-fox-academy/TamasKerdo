using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstSQLServerSetup.Entities;
using FirstSQLServerSetup.Models;
using FirstSQLServerSetup.Repository;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstSQLServerSetup.Controllers
{
    [Route("")]
    public class ToDoController : Controller
    {
        private ToDoContext todoContext;
        private ToDoRepository Repository;

        public ToDoController(ToDoContext todoContext, ToDoRepository Repository)
        {
            this.todoContext = todoContext;
            this.Repository = Repository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            var newtodo = new ToDo()
            {
                Title = "Read Books",
                IsUrgent = true,
                IsDone = true
            };

            todoContext.ToDos.Add(newtodo);
            todoContext.SaveChanges();
            var lasttodo = todoContext.ToDos.LastOrDefault();

            return Json(lasttodo);
        }

        //[Route("list")]
        //public IActionResult List()
        //{            
        //    return View(Repository.GetAll());
        //}

        [Route("list")]
        public IActionResult List([FromQuery] bool isActive)
        {
            return View(Repository.GetActive(isActive));
        }
    }
}
