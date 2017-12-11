using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class SixDice
    {
        private static int[] Dices = new int[6];
             

        public void Roll()
        {
            for (int i = 0; i < Dices.Length; i++)
            {
                Random rn = new Random();
                Dices[i] = rn.Next(1, 7);
            }
            
        }
        public int[] GetDices()
        {
            return Dices;
        }
    }
}
