using System;
using System.Collections.Generic;
using System.Linq;

namespace fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(x => x * x);
            foreach (var l in squares)
            {
                Console.WriteLine(l);
            }           

            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 7 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            foreach (var item in sumList)
            {
                Console.WriteLine(item);
            }

            var numList2 = new List<int>(){1,2,3,4,5};

            Console.WriteLine("Sum:{0}", numList2.Aggregate((a, b) => a + b));

            var numList3 = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Avg:{0}", numList3.AsQueryable().Average());

            Console.WriteLine("All>3:{0}",numList3.All(x=> x > 3));

            Console.WriteLine("Any>3:{0}", numList3.Any(x => x > 3));

            var numList4 = new List<int>() { 1, 2, 3, 2, 3 };
            Console.WriteLine("Distinct : {0}", string.Join(",", numList4.Distinct()));

            Console.WriteLine("Except : {0}", string.Join(",", numList3.Except(numList4)));

            Console.WriteLine("Intersect : {0}", string.Join(",", numList3.Intersect(numList4)));

            Console.ReadLine();
        }
    }
}
