using System;
using System.Linq;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            n.Where(x => (Math.Pow(x, 2) > 20))
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            var filteredn = from filtel in n
                            where Math.Pow(filtel, 2) > 20
                            select filtel;

            foreach (var element in filteredn)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();            
        }
    }
}
