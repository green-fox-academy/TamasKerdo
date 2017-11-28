using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`

            int[] p1 = new int[3] { 1, 2, 3};

            int[] p2 = new int[2] { 4, 5};
            if (p1.Length > p2.Length)
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    Console.Write(p1[i] + " ");
                }

            }
            else
            {
                for (int i = 0; i < p1.Length; i++)
                {
                    Console.Write(p2[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
