using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Counter.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Counter.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        
        public static CounterNumber CounterNumberObject { get; set; } = new CounterNumber();

        [HttpGet]
        public IActionResult Index()
        {            
            return View(CounterNumberObject);
        }


        [HttpPost("add")]
        public IActionResult IncreaseNumber()
        {
            CounterNumberObject.Number++;
            return RedirectToAction("Index");
        }
    }
}
