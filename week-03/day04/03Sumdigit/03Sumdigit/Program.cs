using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            int number = 14537;
            int result = Sumdigit(number);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        private static int Sumdigit(int number)
        {

            if (number / 10 > 0)
            {
                Console.WriteLine(number);
                return number % 10 + Sumdigit(number / 10);
            }
            else
            {
                return number % 10;
            }
        }
    }
}
