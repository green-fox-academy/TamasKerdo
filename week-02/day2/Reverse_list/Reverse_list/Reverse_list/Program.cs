using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_list
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] array = new int[5] {3, 4, 5, 6, 7};
            int[] helperarray = new int[5];
            for (int i = 0; i< array.Length; i++)
            {
                helperarray[i] = array[4-i];
                Console.Write(helperarray[i]+" ");
            }



            Console.ReadLine();

        }
    }
}
