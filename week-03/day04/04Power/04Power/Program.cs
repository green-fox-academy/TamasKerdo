using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            int number = 5;
            int power = 8;
            int result = PowerCalculator(number, power);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int PowerCalculator(int number, int power)
        {
            if (power > 0)
            {
                Console.WriteLine(power);
                return number * PowerCalculator(number,power-1);
            }
            else
            {
                
                return 1;
            }
        }
    }
}
