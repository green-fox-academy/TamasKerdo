using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_elements
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = new string[3] { "first", "second", "third" };
            string helper = abc[0];
            abc[0] = abc[2];
            abc[2] = helper;
            Console.ReadLine();


        }
    }
}
