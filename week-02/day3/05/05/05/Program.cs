using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            StringReserver(reversed);

            Console.WriteLine(reversed);
        }
        static void StringReserver(string rev)
        {
            
            StringBuilder builder = new StringBuilder();
            int j;
            for (int i = 0; i < rev.Length; i++)
            {
                j = rev.Length - i;
                builder.Append(rev[j-1]);
                Console.WriteLine(builder);
            }
            Console.Read();

        }
    }
}
