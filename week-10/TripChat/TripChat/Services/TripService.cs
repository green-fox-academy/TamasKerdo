using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        internal void ListAllLocations(long? tripId)
        {
            throw new NotImplementedException();
        }
    }
}
