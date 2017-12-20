using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_Game
{
    class Hero : Character
    {
        public string UpLookout { get; set; }
        public string LeftLookout { get; set; }
        public string RightLookout { get; set; }
        public bool key { get; set; }

        public Hero(int xPosition, int yPosition)
        {            
            LeftLookout = "Images/hero-left.png";
            UpLookout = "Images/hero-up.png";
            RightLookout = "Images/hero-right.png";
            basicLookout = "Images/hero-down.png";
            key = false;
            var rn = new Random();
            rn.Next(1, 7);
            HP = 20 + 3 * rn.Next(1, 7);
            DP = 2 * rn.Next(1, 7);
            SP = 5 + rn.Next(1, 7);
            position[0] = xPosition;
            position[1] = yPosition;            
        }                
    }
}
