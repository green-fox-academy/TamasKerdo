using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise16
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("Give me the number of the chickens");
            string input = Console.ReadLine();
            int chickenNumber;
            Int32.TryParse(input, out chickenNumber);

            Console.WriteLine("Give me the number of the pigs");
            input = Console.ReadLine();
            int pigNumber;
            Int32.TryParse(input, out pigNumber);

            int legNumber = chickenNumber * 2 + pigNumber * 4;
            Console.WriteLine("number of the legs: " + legNumber);
            Console.ReadLine();

            
        }
    }
}
