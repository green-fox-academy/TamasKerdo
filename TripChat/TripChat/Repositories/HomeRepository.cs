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

        public long? CreateNewTrip(string tripName, string tripDescription, long? userId, string dateOfTheTrip)
        {
            User user = LoadTripsToUsers().FirstOrDefault(u => u.UserId == userId);

            Trip newTrip = new Trip();
            newTrip.Name = tripName;
            newTrip.TimeOfTripPostCreated = DateTime.Now;
            newTrip.Description = tripDescription;
            newTrip.DateOfTheTrip = dateOfTheTrip;
            newTrip.OrganisedBy = user.Name;
            Context.Trips.Add(newTrip);
            Context.SaveChanges();

            UserTrip newUserTrip = new UserTrip() { User = user, Trip = newTrip, UserId = userId, TripId = newTrip.TripId };
            user.UserTrips.Add(newUserTrip);
            Context.SaveChanges();
            return newUserTrip.TripId;
        }


        public void AddNewLocation(long? tripId, float altitude, float longitude, string description, long? userId)
        {
            Trip trip = LoadUsersToTrips().FirstOrDefault(t => t.TripId == tripId);
            Location newLocation = new Location();
            newLocation.Description = description;
            newLocation.Latitude = longitude;
            newLocation.Longitude = longitude;
            trip.TripLocations.Add(newLocation);
            Context.SaveChanges();
        }

        internal string GetTheNameOfTheCurrentUser(long? userId)
        {
            return Context.Users.FirstOrDefault(u => u.UserId == userId).Name;
        }

        public List<Trip> GetTripsOrganisedByTheUser(long? userId)
        {
            var users = LoadTripsToUsers();
            var ReturnList = new List<Trip>();

            if (users.Any(u => u.UserId == userId))
            {
                string userName = users.FirstOrDefault(u => u.UserId == userId).Name;

                var TripsConnectedToUser = new List<Trip>();

                TripsConnectedToUser = users.FirstOrDefault(u => u.UserId == userId)
                                .UserTrips.Select(u => u.Trip)
                                .ToList();
                foreach (var trip in TripsConnectedToUser)
                {
                    if (trip.OrganisedBy.Equals(userName))
                    {
                        ReturnList.Add(trip);
                    }
                }
            }
            return ReturnList;
        }

        internal void RevokeApplyFromTrip(long? tripId, long? userId)
        {
            var appliedList = GetAppliedTrips(userId);
            var trip = new Trip();
            trip = appliedList.FirstOrDefault(t => t.TripId == tripId);
            var user = new User();
            user = Context.Users.FirstOrDefault(u => u.UserId == userId);
            var userTrip = new UserTrip();
            userTrip = trip.UserTrips.FirstOrDefault(t => t.TripId == tripId && t.UserId == userId);
            trip.UserTrips.Remove(userTrip);
            Context.SaveChanges();
        }

        public List<Trip> GetAppliedTrips(long? userId)
        {
            var trips = LoadUsersToTrips();
            var ReturnList = new List<Trip>();
            string userName = Context.Users.FirstOrDefault(u => u.UserId == userId).Name;
            foreach (var trip in trips)
            {
                if ((trip.UserTrips.Any(t => t.UserId == userId)) && (trip.OrganisedBy != userName))
                {
                    ReturnList.Add(trip);
                }
            }
            return ReturnList;
        }

        public List<Trip> GetPotencialTripsToApply(long? userId)
        {
            var trips = LoadUsersToTrips();
            var potencialTripList = new List<Trip>();

            foreach (var trip in trips)
            {
                bool helper = false;
                foreach (var userTrip in trip.UserTrips)
                {
                    if (userTrip.UserId == userId)
                    {
                        helper = true;
                    }
                }
                if (helper == false)
                {
                    potencialTripList.Add(trip);
                }
            }
            return potencialTripList;
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

        public void ApplyForTrip(long? tripId, long? userId)
        {
            Trip trip = LoadUsersToTrips().FirstOrDefault(t => t.TripId == tripId);
            User userToAdd = Context.Users.FirstOrDefault(u => u.UserId == userId);

            UserTrip newUserTrip = new UserTrip() { User = userToAdd, Trip = trip, UserId = userId, TripId = trip.TripId };
            trip.UserTrips.Add(newUserTrip);
            Context.SaveChanges();
        }
    }
}

