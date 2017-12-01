using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me a number:");
            string input = Console.ReadLine();
            char[] array = new char[input.Length];
            array = input.ToCharArray();
            double sum=0;
            foreach (var number in array)
            {
               sum += Math.Pow((int)Char.GetNumericValue(number), array.Length);
                               
            }
            Console.WriteLine(sum);
            

            Console.ReadLine();
        }
    }
}
