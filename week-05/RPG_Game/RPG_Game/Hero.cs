using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    class Hero : Character
    {
        
        public Hero(int xPosition, int yPosition)
        {
            var rn = new Random();
            rn.Next(1, 7);
            HP = 20 + 3 * rn.Next(1, 7);
            DP = 2 * rn.Next(1, 7);
            SP = 5 + rn.Next(1, 7);
            position[0] = xPosition;
            position[1] = yPosition;
        }

        public void Leveling()
        {
            var rn = new Random();
            rn.Next(1, 7);
            HP = HP + rn.Next(1, 7);
            DP = DP + rn.Next(1, 7);
            SP = SP + rn.Next(1, 7);
        }

        
    }
}
