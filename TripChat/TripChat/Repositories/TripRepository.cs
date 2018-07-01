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
                    .Include(t => t.TripLocations)
                    .ToList();
        }

        public List<Trip> LoadChatsToTrips(long? tripId)
        {
            return Context.Trips
                    .Include(t => t.TripChats)
                    .ToList();
        }
                
        public List<Chat> ListAllChatMassages(long? tripId)
        {
            var ChatOfTheTrip = LoadChatsToTrips(tripId);
            return ChatOfTheTrip.FirstOrDefault(t => t.TripId == tripId).TripChats.ToList();
        }

        public void AddNewChatMassageToTrip(string newMassage, long? tripId, long? userId)
        {
            string ChatCreatedBy = Context.Users.FirstOrDefault(u => u.UserId == userId).Name;
            var trips = LoadChatsToTrips(tripId);
            var newChatMassage = new Chat();
            newChatMassage.Content = newMassage;
            newChatMassage.TimeOfThePost = DateTime.Now;
            newChatMassage.CreatedBy = ChatCreatedBy;
            trips.FirstOrDefault(t => t.TripId == tripId).TripChats.Add(newChatMassage);
            Context.SaveChanges();
        }
    }
}