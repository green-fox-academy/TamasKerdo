using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Models;
using TripChat.Repositories;

namespace TripChat.Services
{
    public class HomeService
    {
        public HomeRepository Repository { get; set; }

        public HomeService(HomeRepository repository)
        {
            Repository = repository;
        }

        internal List<Trip> GetAllTripList()
        {
            return Repository.GetAllTheTrips();
        }

        public long? CreateNewTrip(string tripName, string tripDescription, long? userId)
        {
            if (tripName !=null&& userId != null)
            {
                return Repository.CreateNewTrip(tripName, tripDescription, userId);
            };
            return null;
        }
        
        public void AddNewLocation(long? tripId, float altitude, float longitude, string description, long? userId)
        {
            if (tripId != null&& userId !=null)
            {
                Repository.AddNewLocation(tripId, altitude, longitude, description, userId);
            }           
        }

        public List<Trip> GetTripsOfUser(long? userId)
        {
            if (userId != null)
            {
                return Repository.GetTripsOfUser(userId);
            }
            return null;
        }

        public string GetTheNameOfTheCurrentUser(long? userId)
        {
            if (userId != null)
            {
                return Repository.GetTheNameOfTheCurrentUser(userId);
            }
            return null;
        }

        public List<Trip> GetTripsNotOrganisedByTheUser(long? userId)
        {
            if (userId != null)
            {
                return Repository.GetTripsNotOrganisedByTheUser(userId);
            }
            return null;
        }
    }
}
