using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripChat.Models
{
    public class TripChat
    {
        public long? TripChatId { get; set; }
        public string Content { get; set; }
        public DateTime TimeOfThePost { get; set; }

        public Trip Trip { get; set; }
    }
}
