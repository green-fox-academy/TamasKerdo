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

        public long? CreateNewTrip(string tripName, string tripDescription, long? userId, string dateOfTheTrip)
        {
            if (tripName != null && userId != null)
            {
                return Repository.CreateNewTrip(tripName, tripDescription, userId, dateOfTheTrip);
            };
            return null;
        }

        public void AddNewLocation(long? tripId, float altitude, float longitude, string description, long? userId)
        {
            if (tripId != null && userId != null)
            {
                Repository.AddNewLocation(tripId, altitude, longitude, description, userId);
            }
        }

        public List<Trip> GetTripsOrganisedByTheUser(long? userId)
        {
            if (userId != null)
            {
                return Repository.GetTripsOrganisedByTheUser(userId);
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

        public List<Trip> GetPotencialTripsToApply(long? userId)
        {
            if (userId != null)
            {
                return Repository.GetPotencialTripsToApply(userId);
            }
            return null;
        }

        public List<Trip> GetAppliedTrips(long? userId)
        {
            return Repository.GetAppliedTrips(userId);
        }

        public void ApplyForTrip(long? tripId, long? userId)
        {
            if (tripId != null && userId != null)
            {
                Repository.ApplyForTrip(tripId, userId);
            }

        }

        internal void RevokeApplyFromTrip(long? tripId, long? userId)
        {
            if (tripId != null && userId != null)
            {
                Repository.RevokeApplyFromTrip(tripId, userId);
            }
        }
    }
}
