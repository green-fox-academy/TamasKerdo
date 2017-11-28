using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_element
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element



            int[] t = new int[5] {1, 2, 3, 4, 5};
            t[2]++;
            Console.Write(t[2]);
            Console.ReadLine();

        }
    }
}
