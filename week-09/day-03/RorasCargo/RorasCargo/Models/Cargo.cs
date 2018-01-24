using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Models
{
    public class Cargo
    {
        public int caliber25 { get; set; } = 0;
        public int caliber30 { get; set; } = 0;
        public int caliber50 { get; set; } = 0;
        public string IsEmpty { get; set; } = "empty";
        public bool Ready { get; set; } = false;
    }
}
