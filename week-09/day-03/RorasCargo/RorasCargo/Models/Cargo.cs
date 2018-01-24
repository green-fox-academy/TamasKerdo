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


        public void FillInAmmo(string caliber, int amount)
        {
            if (caliber == ".25")
            {
                caliber25 += amount;
            }
            else if (caliber == ".30")
            {
                caliber30 += amount;
            }
            else if (caliber == ".50")
            {
                caliber50 += amount;
            }
        }

        public string CheckCargoStatus()
        {
            int fullAmmo = caliber25 + caliber30 + caliber50;
            float ammoPercentage = (fullAmmo / 12500) * 100;
            if (fullAmmo == 12500)
            {
                IsEmpty = "full";
                return "full";
            }
            else if (fullAmmo == 0)
            {
                return "empty";
            }
            else if (fullAmmo > 12500)
            {
                return "overloaded";
            }
            return fullAmmo.ToString();
        }
    }
}