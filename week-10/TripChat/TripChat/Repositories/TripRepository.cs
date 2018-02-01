using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Entities;
using TripChat.Models;

namespace TripChat.Repositories
{
    public class TripRepository
    {
        public UserContext Context { get; set; }

        public TripRepository(UserContext context)
        {
            Context = context;
        }

        public List<Location> ListAllLocations(long? tripId)
        {
            var TripList = LoadLocationsToTrips();
            return TripList.FirstOrDefault(t => t.TripId == tripId).TripLocations.ToList();
        }

        public List<Trip> LoadLocationsToTrips()
        {
            return Context.Trips
                    .Include(blog => blog.TripLocations)
                    .ToList();
        }
    }
}