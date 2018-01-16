using System;
using System.Linq;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            cities.Where(x => (x.StartsWith('A') && (x.EndsWith('I')))).ToList().ForEach(x=> Console.WriteLine(x));
            Console.ReadLine();
        }
    }
}
