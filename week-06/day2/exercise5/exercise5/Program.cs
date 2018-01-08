using System;
using System.Linq;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfn = n.OrderByDescending(x => x)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, x => x.Count());

            foreach (var element in frequencyOfn)
            {
                Console.WriteLine($"element: {element.Key} frequency: {element.Value}");
            }
            Console.ReadLine();
        }
    }
}
