using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter

            string input = Console.ReadLine();
            int parameter;
            Int32.TryParse(input, out parameter);
                
            Console.WriteLine(Parameter(parameter));
            Console.ReadLine();


            
        }

        static int Parameter(int parameter)
        {
            int helper = 0;
            for (int i = 1; i < parameter+1; i++)
            {
                helper =helper + i;
                Console.WriteLine(helper);
            }
            return helper;
        }
    }
}
