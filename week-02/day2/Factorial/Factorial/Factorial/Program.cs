using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            

            string input = Console.ReadLine();
            int parameter;
            Int32.TryParse(input, out parameter);
            Console.WriteLine(factorio(parameter));
            Console.ReadLine();
        }

        static int factorio(int parameter)
        {
            int helper=1;
            for (int i = 1; i< parameter + 1; i++)
            {
                helper = helper * i;
            }
            return helper;
        }
    }
}
