using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripChat.Repositories;

namespace TripChat.Services
{
    public class HomeService
    {
        public HomeRepository Repository { get; set; }

        public HomeService(HomeRepository repository)
        {
            Repository = repository;
        }
    }
}
