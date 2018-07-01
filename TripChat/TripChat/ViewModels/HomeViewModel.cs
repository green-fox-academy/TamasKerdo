using System.Collections.Generic;
using TripChat.Models;

namespace TripChat.ViewModels
{
    public class HomeViewModel
    {
        public long? ViewModelId { get; set; } = null;
        public string NameOfTheCurrentUser { get; set; }
        public List<Trip> PotencialTripsToApply { get; set; } = new List<Trip>();
        public List<Trip> ListOftTheUserTrips { get; set; } = new List<Trip>();
        public List<Trip> ListOfUserApplies { get; set; } = new List<Trip>();
    }
}
