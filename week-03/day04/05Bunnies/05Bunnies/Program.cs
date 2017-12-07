using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            int bunnyNumber = 30;
            int earNumber = 0;
            
            Console.WriteLine(BunnieCounter(bunnyNumber, earNumber));
            Console.ReadLine();
        }

        static int BunnieCounter(int bunnyNumber, int earNumber)
        {

            if (bunnyNumber > 0)
            {

                return BunnieCounter(--bunnyNumber, earNumber + 2);
            }
            else
            {
                return earNumber;
            }
        }
    }
}
