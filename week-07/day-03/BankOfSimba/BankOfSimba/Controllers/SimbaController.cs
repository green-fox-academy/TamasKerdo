using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankOfSimba.Controllers
{
    [Route("")]
    public class SimbaController : Controller
    {
        public static AccountViewModel AccountList { get; set; } = new AccountViewModel();

        [Route("")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            var simba = new BankAccounts() {Name = "Simba", Balance = 2000.00, AnimalType = "Animal.Lion" };
            var zebra = new BankAccounts() { Name = "zebra", Balance = 2000.00, AnimalType = "Animal.zebra" };
            AccountList.AddNewAccount(simba);
            AccountList.AddNewAccount(zebra);
            return View(AccountList);
        }
    }
}
