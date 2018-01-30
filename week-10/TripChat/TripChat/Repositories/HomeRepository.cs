using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Repositories
{
    public class HomeRepository
    {
        public DbContext Context { get; set; }

        public HomeRepository(DbContext context)
        {
            Context = context;
        }

    }
}
