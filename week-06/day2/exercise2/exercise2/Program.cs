using System;
using System.Linq;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            double average = n.Where(x => (x % 2 == 1) || (x % 2 == -1)).Average(x => x);
            Console.WriteLine(average);

            double averageByQuerySyntax = (from ave in n
                                          where (ave % 2 == 1) || (ave % 2 == -1)
                                          select ave).Average();

                Console.WriteLine(averageByQuerySyntax);

            Console.ReadLine();
        }
    }
}
