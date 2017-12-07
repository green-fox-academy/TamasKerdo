using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            int counter=10;
            Recursion(counter);
            Console.ReadLine();
        }

        static void Recursion(int counter)
        {
            
            Console.WriteLine(counter);
            if (counter > 0)
            {
                Recursion(--counter);
            }
        }
    }
}
