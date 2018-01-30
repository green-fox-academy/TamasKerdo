using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Models
{
    public class Trip
    {
        public long? TripId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        
        public string DateOfTheTrip { get; set; }
        public DateTime TimeOfTripPostCreated { get; set; }

        public ICollection<TripLocation> TripLocations { get; } = new List<TripLocation>();
        public ICollection<TripChat> TripChats { get; } = new List<TripChat>();

        public ICollection<UserTrip> UserTrips { get; } = new List<UserTrip>();        
    }
}
