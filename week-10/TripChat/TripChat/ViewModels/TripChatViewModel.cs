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
        public List<Trip> ListOfTrips { get; set; } = new List<Trip>();
    }
}
