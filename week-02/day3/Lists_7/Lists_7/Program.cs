using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

            int a = list.IndexOf("create,");
            int b = list.IndexOf("not");
            list.RemoveAt(b);
            list.Insert(a,"not");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
