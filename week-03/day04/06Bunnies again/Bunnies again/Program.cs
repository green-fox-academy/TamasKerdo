using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnies_again
{
    class Program
    {
        static void Main(string[] args)
        {

            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            int bunnieNumber = 10;   
            
            Console.WriteLine(BunnieCounter(bunnieNumber));
            Console.ReadLine();

        }

        static int BunnieCounter(int bunnieNumber)
        {
            if (bunnieNumber == 1)
            {
                Console.WriteLine(1);
                return 2;

            }
            else if (bunnieNumber % 2 == 0)
            {
                Console.WriteLine(bunnieNumber);
                return 3 + BunnieCounter(--bunnieNumber);
            }
            else 
            {
                Console.WriteLine(bunnieNumber);
                return 2 + BunnieCounter(--bunnieNumber);
            }
            
        }
    }
}
