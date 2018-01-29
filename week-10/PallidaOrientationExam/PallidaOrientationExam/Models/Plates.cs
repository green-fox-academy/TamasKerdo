using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Models
{
    public class Plates
    {
        public long? Id { get; set; }
        public string Plate { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
    }
}