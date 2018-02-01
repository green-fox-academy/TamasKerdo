using System;
using System.Collections.Generic;
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

        internal List<Chat> ListAllChatMassages(long? tripId)
        {
            if (tripId != null)
            {
                return Repository.ListAllChatMassages(tripId);
            }
            return null;
        }

        public void AddNewChatMassageToTrip(string newMassage, long? tripId, long? userId)
        {
            if ((tripId != null)&&(newMassage!=null)&&(userId!=null))
                Repository.AddNewChatMassageToTrip(newMassage, tripId, userId);
        }
    }
}
