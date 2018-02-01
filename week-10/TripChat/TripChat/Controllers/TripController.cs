using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripChat.Services;
using TripChat.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripChat.Controllers
{
    public class TripController : Controller
    {
        public TripService Service { get; set; }
        public TripViewModel TripViewModel { get; set; }
        public static float? UserId { get; set; }
        public static float? TripId { get; set; }

        public TripController(TripService service, TripViewModel tripViewModel)
        {
            Service = service;
            TripViewModel = tripViewModel;
        }
        [Route("trip")]
        public IActionResult Index(long? tripId, long? userId)
        {
            UserId = userId;
            TripId = tripId;
            TripViewModel.Locations = Service.ListAllLocations(tripId);
            return View(TripViewModel);
        }
    }
}
