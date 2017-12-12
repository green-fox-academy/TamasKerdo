using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Flower
    {
        public string Color { get; set; }
        public int WaterAmount { get; set; }

        public Flower(string Color)
        {
            this.Color = Color;
            WaterAmount = 0;
        }

        public void GiveWater(int WaterAmount)
        {
            this.WaterAmount += (WaterAmount / 4)*3;
        }

        public string GetStatus()
        {
            if (WaterAmount < 5)
            {
                return "The " + Color + " Flower needs water";
            }
            else
            {
                return "The " + Color + " Flower doesnt needs water";
            }
        }
    }
}
