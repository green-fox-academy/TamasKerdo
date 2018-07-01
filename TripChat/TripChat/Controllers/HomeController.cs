using Microsoft.AspNetCore.Mvc;
using TripChat.Services;
using TripChat.ViewModels;


namespace TripChat.Controllers
{
    [Route("main")]
    public class HomeController : Controller
    {
        public HomeService Service { get; set; }
        public HomeViewModel HomeViewModel { get; set; }
        public static long? UserId { get; set; }

        public HomeController(HomeService service, HomeViewModel tripChatViewModel)
        {
            Service = service;
            HomeViewModel = tripChatViewModel;
        }        

        [Route("")]
        public IActionResult Index(long? userId)
        {
            if (userId!=null)            
                UserId = userId;
            HomeViewModel.NameOfTheCurrentUser = Service.GetTheNameOfTheCurrentUser(UserId);
            HomeViewModel.ListOftTheUserTrips = Service.GetTripsOrganisedByTheUser(UserId);
            HomeViewModel.PotencialTripsToApply = Service.GetPotencialTripsToApply(UserId);
            HomeViewModel.ListOfUserApplies = Service.GetAppliedTrips(UserId);            
            
            return View(HomeViewModel);
        }

        [HttpGet("IndexFromLocations")]
        public IActionResult IndexFromLocations()
        {
            return RedirectToAction("Index",UserId);
        }

        [HttpGet("createNewTrip")]
        public IActionResult CreateNewTrip()
        {            
            return View(HomeViewModel);
        }

        [HttpPost("addLocation")]
        public IActionResult AddLocation([FromForm] string tripName, [FromForm] string description, [FromForm] long? tripId, [FromForm] float altitude, [FromForm] float longitude, [FromForm] string dateOfTheTrip)
        {

            HomeViewModel.ViewModelId = tripId;
            if (HomeViewModel.ViewModelId == null)
            {
                HomeViewModel.ViewModelId = Service.CreateNewTrip(tripName, description, UserId, dateOfTheTrip);
                return View(HomeViewModel);
            }
            else
            {                
                Service.AddNewLocation(tripId, altitude, longitude, description,UserId);
            }
            return View(HomeViewModel);
        }

        [Route("apply/{TripId}")]
        public IActionResult ApplyForTheTrip([FromRoute] long? TripId)
        {
            Service.ApplyForTrip(TripId,UserId);
            return RedirectToAction("Index", UserId);
        }

        [Route("revokeApply/{TripId}")]
        public IActionResult RevokeApplyForTheTrip([FromRoute] long? TripId)
        {
            Service.RevokeApplyFromTrip(TripId, UserId);
            return RedirectToAction("Index", UserId);
        }

        [Route("tripDetails/{TripId}")]
        public IActionResult TripDetails([FromRoute] long? TripId)
        {
            return RedirectToAction("Index", "Trip", new { userId = UserId, tripId = TripId });
        }
    }
}
