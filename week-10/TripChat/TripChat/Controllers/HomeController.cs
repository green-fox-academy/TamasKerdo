using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripChat.Services;
using TripChat.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripChat.Controllers
{
    [Route("main")]
    public class HomeController : Controller
    {
        public HomeService Service { get; set; }

        public HomeController(HomeService service)
        {
            Service = service;
        }
        [Route("")]
        public IActionResult Index()
        {
            //List<Trip> tripList = Service.GetAllTripList();
            List<Trip> newList = new List<Trip>();
            return View(newList);
        }
    }
}
