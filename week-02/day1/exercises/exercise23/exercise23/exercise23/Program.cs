using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise23
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " I won't cheat on the exam!");
                
            }
            Console.ReadLine();
        }
    }
}
