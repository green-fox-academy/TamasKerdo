using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TripChat.Entities;
using TripChat.Models;

namespace TripChat.Repositories
{
    public class HomeRepository
    {
        public UserContext Context { get; set; }

        public HomeRepository(UserContext context)
        {
            Context = context;
        }

        public List<Trip> GetAllTheTrips()
        {
            return Context.Trips.ToList();
        }

        public long? CreateNewTrip(string tripName, string tripDescription, long? userId)
        {
            User user = LoadTripsToUsers().FirstOrDefault(u=>u.UserId == userId);

            Trip newTrip = new Trip();
            newTrip.Name = tripName;
            newTrip.Description = tripDescription;
            newTrip.OrganisedBy = user.Name;
            Context.Trips.Add(newTrip);
            Context.SaveChanges();

            UserTrip newUserTrip = new UserTrip() {User = user, Trip = newTrip, UserId = userId, TripId = newTrip.TripId };
            user.UserTrips.Add(newUserTrip);
            Context.SaveChanges();
            return newUserTrip.TripId;
        }
        

        public void AddNewLocation(long? tripId, float altitude, float longitude, string description, long? userId)
        {
            Trip trip = LoadUsersToTrips().FirstOrDefault(t=>t.TripId == tripId);
            Location newLocation = new Location();
            newLocation.Description = description;
            newLocation.Latitude = longitude;
            newLocation.Longitude = longitude;
            trip.TripLocations.Add(newLocation);
            Context.SaveChanges();
        }

        internal string GetTheNameOfTheCurrentUser(long? userId)
        {
            return Context.Users.FirstOrDefault(u=>u.UserId == userId).Name;
        }

        public List<Trip> GetTripsOfUser(long? userId)
        {
            var users = LoadTripsToUsers();

            if (users.Any(u => u.UserId == userId))
            {
                return users.FirstOrDefault(u => u.UserId == userId)
                .UserTrips.Select(u => u.Trip)
                .ToList();
            }
            return null;
        }

        public List<Trip> GetTripsNotOrganisedByTheUser(long? userId)
        {
            var users = LoadTripsToUsers();
            if (users.Any(u => u.UserId != userId))
            {
                return users.FirstOrDefault(u => u.UserId != userId)
                .UserTrips.Select(u => u.Trip)
                .ToList();
            }
            return null;
        }

        public List<User> GetUsersOfTrip(long? tripId)
        {
            var trips = LoadUsersToTrips();

            return trips.FirstOrDefault(t => t.TripId == tripId)
                .UserTrips.Select(t => t.User)
                .ToList();
        }

        public List<User> LoadTripsToUsers()
        {
            var users = Context.Users
                .Include(u => u.UserTrips)
                .ThenInclude(u => u.Trip)
                .ToList();

            return users;
        }

        public List<Trip> LoadUsersToTrips()
        {
            var trips = Context.Trips
                .Include(t => t.UserTrips)
                .ThenInclude(t => t.User)
                .ToList();

            return trips;
        }
    }
}
