using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.
            float fizzSensor;
            float buzzSensor;
            for (int i = 1; i < 101; i++)
            {
                fizzSensor = i % 3;
                buzzSensor = i % 5;
                if (fizzSensor == 0 && buzzSensor == 0)
                {
                    Console.WriteLine("fizzBUzz");

                }
                else if (fizzSensor == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else if (buzzSensor == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }


            }
            Console.ReadLine();
        }
    }
}
