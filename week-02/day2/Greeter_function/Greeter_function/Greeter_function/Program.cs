using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeter_function
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`


            string al = "Greenfox";
            Greet(al);
            Console.ReadLine();
        }
        static void Greet (string greetAl)
        {
            Console.WriteLine("greetings " + greetAl);
        }
    }
}
