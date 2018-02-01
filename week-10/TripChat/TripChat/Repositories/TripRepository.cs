using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Entities;

namespace TripChat.Repositories
{
    public class TripRepository
    {
        public UserContext Context { get; set; }

        public TripRepository(UserContext context)
        {
            Context = context;
        }
    }
}
