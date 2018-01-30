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
            throw new NotImplementedException();
        }

        internal long? CreateNewTrip(string tripName, string tripDescription)
        {
            throw new NotImplementedException();
        }

        internal void AddNewLocation(long? tripId, float altitude, float longitude, string description)
        {
            throw new NotImplementedException();
        }
    }
}
