using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise26
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("give me two numbers!!");
            
            int inputNumber1;
            string input = Console.ReadLine();
            Int32.TryParse(input, out inputNumber1);

            int inputNumber2;
            input = Console.ReadLine();
            Int32.TryParse(input, out inputNumber2);

            if (inputNumber1 > inputNumber2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                int countNumber = inputNumber2 - inputNumber1;

                for (int i = 0; i < countNumber; i++)
                {
                    Console.WriteLine(inputNumber1 + i + 1);
                }
            }
            Console.ReadLine();

        }
    }
}
