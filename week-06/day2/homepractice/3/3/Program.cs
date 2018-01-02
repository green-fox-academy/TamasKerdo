using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> flipList = new List<int>();

            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine("Heads : {0}", flipList.Where(a => a == 1).ToList().Count());
            Console.WriteLine("Tails : {0}", flipList.Where(a => a == 2).ToList().Count());

            var nameList = new List<string>
            {"Doug", "Sally", "Sue" };

            var sNameList = nameList.Where(x => x.StartsWith("S"));
            foreach (var item in sNameList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
