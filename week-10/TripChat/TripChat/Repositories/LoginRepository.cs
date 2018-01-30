using System.Linq;
using TripChat.Entities;
using TripChat.Models;

namespace TripChat.Repositories
{
    public class LoginRepository
    {
        public UserContext Context { get; set; }

        public LoginRepository(UserContext context)
        {
            Context = context;
        }

        internal long? CreateNewUser(string userName)
        {
            bool containsUser = Context.Users.Any(u => u.Name == userName);
            if (!containsUser)
            {
                User newUser = new User();
                newUser.Name = userName;
                newUser.OrganisedTrips = 0;
                Context.Users.Add(newUser);
                Context.SaveChanges();
                return Context.Users.FirstOrDefault(u => u.Name == userName).UserId;                
            }
            return null;
            
        }

        internal long? Check(string userName)
        {
            if (Context.Users.Any(u => u.Name == userName))
            {
                return Context.Users.FirstOrDefault(u => u.Name == userName).UserId;
            }
            return null;
        }
    }
}
