using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...


            Console.WriteLine("give me numbers and I print it to you!");
            Console.WriteLine("after the last number please press 'p' button!");
            string input;
            int parameter;
            List<string> parameterList = new List<string>();
            input = Console.ReadLine();
            while (input != "p")
            {
                parameterList.Add(input);
                input = Console.ReadLine();
            }

            string[] parameterArray = new string[parameterList.Count];

            for (int i = 0; i < parameterList.Count; i++)
            {
                parameterArray[i] = parameterList[i];
            }

            Printer(parameterArray);
            

            Console.ReadLine();
        }

        static void Printer(params string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" "+ array[i]);
            }
            Console.WriteLine();
        }

    }
}
