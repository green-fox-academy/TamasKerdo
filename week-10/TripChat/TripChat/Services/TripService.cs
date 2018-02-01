using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Models;
using TripChat.Repositories;

namespace TripChat.Services
{
    public class TripService
    {
        public TripRepository Repository { get; set; }

        public TripService(TripRepository repository)
        {
            Repository = repository;
        }

        public List<Location> ListAllLocations(long? tripId)
        {
            if (tripId!=null)
            {
                return Repository.ListAllLocations(tripId);
            }
            return null;
        }
    }
}
