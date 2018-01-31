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
        public TripChatViewModel TripChatViewModel { get; set; }
        public static long? UserId { get; set; }

        public HomeController(HomeService service, TripChatViewModel tripChatViewModel)
        {
            Service = service;
            TripChatViewModel = tripChatViewModel;
        }        

        [Route("")]
        public IActionResult Index(long? userId)
        {
            UserId = userId;
            TripChatViewModel.ListOfTrips = Service.GetAllTripList();
            return View(TripChatViewModel);
        }

        [HttpGet("IndexFromLocations")]
        public IActionResult IndexFromLocations()
        {
            return RedirectToAction("Index",UserId);
        }

        [HttpGet("createNewTrip")]
        public IActionResult CreateNewTrip()
        {            
            return View(TripChatViewModel);
        }

        [HttpPost("addLocation")]
        public IActionResult AddLocation([FromForm] string tripName, [FromForm] string description, [FromForm] long? tripId, [FromForm] float altitude, [FromForm] float longitude)
        {
            
            TripChatViewModel.ViewModelId = tripId;
            if (TripChatViewModel.ViewModelId == null)
            {
                TripChatViewModel.ViewModelId = Service.CreateNewTrip(tripName, description, UserId);
                return View(TripChatViewModel);
            }
            else
            {                
                Service.AddNewLocation(tripId, altitude, longitude, description,UserId);
            }
            return View(TripChatViewModel);
        }

        [Route("apply/{TripId}")]
        public IActionResult ApplyForTheTrip([FromRoute] long? TripId)
        {
            var helper = TripId;
            return View(helper);
        }

        [Route("revokeApply/{TripId}")]
        public IActionResult RevokeApplyForTheTrip([FromRoute] long? TripId)
        {
            var helper = TripId;
            return View(helper);
        }

        [Route("tripDetails/{TripId}")]
        public IActionResult TripDetails([FromRoute] long? TripId)
        {
            var helper = TripId;
            return View(helper);
        }
    }
}
