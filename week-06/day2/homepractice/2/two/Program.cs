using System;
using System.Collections.Generic;
using System.Linq;

namespace two
{
    delegate double doubleIt(double val);
    class Program
    {
        static void Main(string[] args)
        {
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5*2 = {dblIt(5)}");

            List<int> numlist = new List<int> { 1, 9, 2, 6, 3 };

            var evenList = numlist.Where(a => a % 2 == 0).ToList();
            foreach (var j in evenList)            
                Console.WriteLine(j);

            var rangeList = numlist.Where(x => (x > 2) && (x < 9)).ToList();

            foreach (var j in rangeList)
                Console.WriteLine(j);

            Console.ReadLine();
        }
    }
}
