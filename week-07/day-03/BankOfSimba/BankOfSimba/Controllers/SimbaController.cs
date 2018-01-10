using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    public class SimbaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var ba = new BankAccounts() {Name = "Simba", Balance = 2000, AnimalType = "Animal.Lion" };
            return View(ba);
        }
    }
}
