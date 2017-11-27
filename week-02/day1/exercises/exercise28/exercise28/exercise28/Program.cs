using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise28
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            Console.WriteLine("number of the triangle rows:");
            string input = Console.ReadLine();
            int triangleRow;
            Int32.TryParse(input, out triangleRow);

            for (int i =1 ; i < triangleRow+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
