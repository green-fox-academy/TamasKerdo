using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_Game
{
    class Monster : Character
    {
        public bool key { get; set; }        

        public Monster(int xPosition, int yPosition, bool key, int Level)
        {
            basicLookout = "Images/skeleton.png";
            var rn = new Random();
            this.key = key;
            switch (Level)
            {
                case 1:

                    HP = 20 + 3 * rn.Next(1, 7);
                    DP = 2 * rn.Next(1, 7);
                    SP = 5 + rn.Next(1, 7);

                    position[0] = xPosition;
                    position[1] = yPosition;
                    break;
                
                default:
                    HP = 20 + 3 * rn.Next(1, 7) + 2 * Level * rn.Next(1, 7);
                    DP = 2 * rn.Next(1, 7) + (Level / 2) * rn.Next(1, 7);
                    SP = 5 + rn.Next(1, 7) + Level * rn.Next(1, 7);

                    position[0] = xPosition;
                    position[1] = yPosition;
                    break;
            }                        
        }        
    }
}
