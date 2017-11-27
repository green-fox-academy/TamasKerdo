using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise20
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("give me 2 numbers");
            string input = Console.ReadLine();
            int numberOne;
            Int32.TryParse(input, out numberOne);

            input = Console.ReadLine();
            int numberTwo;
            Int32.TryParse(input, out numberTwo);

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne + " is bigger!!!!!!");
            }
            else if (numberOne == numberTwo)
            { 
                Console.WriteLine("the two numbers are equals!!!!");
            }
            else
            {
                Console.WriteLine(numberTwo + " is bigger!!!!!!");
            }
            Console.ReadLine();

        }
    }
}
