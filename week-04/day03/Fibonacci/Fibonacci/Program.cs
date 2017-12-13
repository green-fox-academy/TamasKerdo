using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }

    public class Fibo
    {
        public int FiboCounter(int input)
        {
            
            if (input <= 1)
            {
                return 1;
            }
            else
            {
                return FiboCounter(input - 2) + FiboCounter(input - 1);
            }
        }
    }
}
