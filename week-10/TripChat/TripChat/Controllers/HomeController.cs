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

        [HttpGet("createNewTrip")]
        public IActionResult CreateNewTrip()
        {
            long? newTripId = null;
            return View(newTripId);
        }

        [HttpGet("addLocation")]
        public IActionResult AddLocation([FromQuery] string tripName, [FromQuery] string description, [FromQuery] long? tripId, [FromQuery] float altitude, [FromQuery] float longitude)
        {
            if (tripId == null)
            {
                //tripId = Service.CreateNewTrip(tripName, description);
                return View(tripId);
            }
            else
            {
                //Service.AddNewLocation(tripId, altitude, longitude, description);
            }
            return View(tripId);
        }
    }
}
