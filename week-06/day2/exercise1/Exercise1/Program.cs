using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {        
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNumbers = n.Where(x => (x % 2 == 1|| x % 2 == -1))
                .Select(x => x).ToList();

            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }


            var evenNumbersWithQuerySyntax = from evenNum in n
                                         where (evenNum % 2 == 1) || (evenNum % 2 == -1)
                                         select evenNum;           

            foreach (var evenNum in evenNumbersWithQuerySyntax)
            {
                Console.WriteLine(evenNum);
            }

            

            Console.ReadLine();
        }
    }
}
