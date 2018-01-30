
using System.Collections.Generic;

namespace TripChat.Models
{
    public class User
    {
        public long? UserId { get; set; }
        public string Name { get; set; }
        public int OrganisedTrips { get; set; }

        public ICollection<UserTrip> PostTags { get; } = new List<UserTrip>();
    }
}
