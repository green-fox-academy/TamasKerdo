using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Garden_Application
{
    class Tree
    {
        public string Color { get; set; }
        public int WaterAmount { get; set; }

        public Tree(string Color)
        {
            this.Color = Color;
            WaterAmount = 0;
        }

        public void GiveWater(int WaterAmount)
        {
            this.WaterAmount += WaterAmount / 4;
        }

        public string GetStatus()
        {
            if (WaterAmount < 10)
            {
                return "The " + Color + " Tree needs water";
            }
            else
            {
                return "The " + Color + " Tree doesnt needs water";
            }
        }
    }
}
