using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise24
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a program that prints all the even numbers between 0 and 500
            int i = 1;
             while(i<500)
             {
                i += 2;
                 Console.WriteLine(i);
             }
             Console.ReadLine();
        }
    }
}
