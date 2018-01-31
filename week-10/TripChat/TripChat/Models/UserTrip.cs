﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Models
{
    public class UserTrip
    {
        public long? UserId { get; set; }
        public User User { get; set; }

        public long? TripId { get; set; }
        public Trip Trip { get; set; }
    }
}
