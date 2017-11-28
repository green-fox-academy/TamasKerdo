using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] r = new int[4] {54, 23, 66, 12};
            Console.Write(r[1] + " " + r[2]);
            Console.ReadLine();
        }
    }
}
