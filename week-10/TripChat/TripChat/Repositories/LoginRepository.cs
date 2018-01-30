using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Entities;

namespace TripChat.Repositories
{
    public class LoginRepository
    {
        public UserContext Context { get; set; }

        public LoginRepository(UserContext context)
        {
            Context = context;
        }
    }
}
