using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            SixDice Dice = new SixDice();
            bool dicesAllSix = false;
            int RollCounter = 0;
            while (dicesAllSix != true)
            {
                Dice.Roll();
                int[] array = new int[6];
                if (Dice.GetDices().Contains(1) || Dice.GetDices().Contains(2) || Dice.GetDices().Contains(3) || Dice.GetDices().Contains(4) || Dice.GetDices().Contains(5))
                {
                    dicesAllSix = false;
                    RollCounter++;                    
                }
                else
                {
                    dicesAllSix = true;                    
                }  

            }

            Console.WriteLine(RollCounter);
            Console.ReadLine();
        }
    }
}
