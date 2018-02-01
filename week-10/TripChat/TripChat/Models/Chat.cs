﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Models
{
    public class Chat
    {
        public long? ChatId { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfThePost { get; set; }
        public string CreatedBy { get; set; }

        public Trip Trip { get; set; }
    }
}
