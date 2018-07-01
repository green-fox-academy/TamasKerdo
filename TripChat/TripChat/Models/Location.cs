using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Models
{
    public class Location
    {
        public long? LocationId { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Description { get; set; }

        public Trip Trip { get; set; }
    }
}
