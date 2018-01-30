using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Entities;

namespace TripChat.Repositories
{
    public class HomeRepository
    {
        public UserContext Context { get; set; }

        public HomeRepository(UserContext context)
        {
            Context = context;
        }

    }
}
