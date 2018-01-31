using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripChat.Services;
using TripChat.Models;
using TripChat.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripChat.Controllers
{
    [Route("main")]
    public class HomeController : Controller
    {        
        public HomeService Service { get; set; }
        public static long? UserId { get; set; }

        public HomeController(HomeService service)
        {
            Service = service;
        }        

        [Route("")]
        public IActionResult Index()
        {            
            List<Trip> tripList = Service.GetAllTripList();
            return View(tripList);
        }

        [HttpGet("IndexFromLocations")]
        public IActionResult IndexFromLocations()
        {
            return RedirectToAction("Index",UserId);
        }

        [HttpGet("createNewTrip")]
        public IActionResult CreateNewTrip()
        {
            var helper = new TripIdViewModel();
            return View(helper);
        }

        [HttpPost("addLocation")]
        public IActionResult AddLocation([FromForm] string tripName, [FromForm] string description, [FromForm] long? tripId, [FromForm] float altitude, [FromForm] float longitude)
        {
            var helper = new TripIdViewModel();
            helper.ViewModelId = tripId;
            if (helper.ViewModelId == null)
            {
                helper.ViewModelId = Service.CreateNewTrip(tripName, description, UserId);
                return View(helper);
            }
            else
            {                
                Service.AddNewLocation(tripId, altitude, longitude, description,UserId);
            }
            return View(helper);
        }
    }
}
