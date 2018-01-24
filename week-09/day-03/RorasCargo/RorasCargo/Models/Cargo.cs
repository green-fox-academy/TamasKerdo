using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RorasCargo.Models
{
    public class Cargo
    {
        public int caliber25 { get; set; }
        public int caliber30 { get; set; }
        public int caliber50 { get; set; }
        public string IsEmpty { get; set; }
        public bool Ready { get; set; }
    }
}
