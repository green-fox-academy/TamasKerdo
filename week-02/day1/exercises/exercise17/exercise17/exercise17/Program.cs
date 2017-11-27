using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise17
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            Console.WriteLine("Give me 3 numbers NOW!!!");
            string input = Console.ReadLine();
            int numberOne;
            Int32.TryParse(input, out numberOne);

            input = Console.ReadLine();
            int numberTwo;
            Int32.TryParse(input, out numberTwo);

            input = Console.ReadLine();
            int numberThree;
            Int32.TryParse(input, out numberThree);

            int sum = (numberOne + numberTwo + numberThree)/3;
            Console.WriteLine("the sum is: " + sum);

            int average = (numberOne + numberTwo + numberThree);
            Console.WriteLine("the sum is: " + average);

            Console.ReadLine();

        }
    }
}
