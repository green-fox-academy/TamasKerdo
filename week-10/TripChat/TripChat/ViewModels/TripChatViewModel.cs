using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Models;

namespace TripChat.ViewModels
{
    public class TripChatViewModel
    {
        public long? ViewModelId { get; set; } = null;
        public string NameOfTheCurrentUser { get; set; }
        public List<Trip> ListOfTripsNotOrganisedByTheUser { get; set; } = new List<Trip>();
        public List<Trip> ListOftTheUserTrips { get; set; } = new List<Trip>();
    }
}
