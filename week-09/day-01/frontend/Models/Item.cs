using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class Item
    {
        public int? Until { get; set; }
        public string What { get; set; }
        public int[] Numbers { get; set; }
    }
}
