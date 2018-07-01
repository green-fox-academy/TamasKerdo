using System.Collections.Generic;
using TripChat.Models;

namespace TripChat.ViewModels
{
    public class TripViewModel
    {
        public List<Location> Locations { get; set; } = new List<Location>();
        public List<Chat> ChatMassages { get; set; } = new List<Chat>();
    }
}
