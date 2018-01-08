using System;
using System.Linq;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double positiveAverage = n.Where(x => (x >= 0))
                .Select(x => Math.Pow(x, 2))
                .Average();

            Console.WriteLine(positiveAverage);

            double posAverage = (from number in n
                             where (number >= 0)
                             select Math.Pow(number, 2))
                             .Average();

            Console.WriteLine(posAverage);

            Console.ReadLine();
        }
    }
}
