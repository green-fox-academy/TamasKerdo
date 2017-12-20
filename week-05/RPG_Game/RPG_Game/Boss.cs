using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;

namespace RPG_Game
{
    class Boss : Character
    {
        public Boss(int xPosition, int yPosition, int Level)
        {
            basicLookout = "Images/boss.png";            
            var rn = new Random();            
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
                    HP = 20 + 3 * rn.Next(1, 7) + 2 * Level * rn.Next(1, 7) + rn.Next(1, 7);
                    DP = 2 * rn.Next(1, 7) + (Level / 2) * rn.Next(1, 7) + rn.Next(1, 7)/2;
                    SP = 5 + rn.Next(1, 7) + Level * rn.Next(1, 7) + Level;

                    position[0] = xPosition;
                    position[1] = yPosition;
                    break;
            }            
        }        
    }
}
