using System;
using System.Linq;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //Query Syntax

            var number = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            //Output of Query Syntax
            Console.WriteLine("Output of Query syntax");
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }

            //Method synatx
            var nummethod = numbers.Where(x => (x % 2 == 0)).OrderBy(x => x);

            //Output of Method Syntax
            Console.WriteLine("Output of Method syntax");
            foreach (var num1 in nummethod)
            {
                Console.WriteLine(num1);
            }
            Console.ReadLine();
        }
    }
}
