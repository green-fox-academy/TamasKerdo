using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            // Check if the arrayList contains "7" if it contains print "Hoorray" otherwise print "Noooooo"
            // Do this again with a different solution using different list functions!


            //Solution 1


            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].Equals(7))
                {
                    Console.WriteLine("Hooray");
                }
                else if(i==List.Count-1)
                {
                    Console.WriteLine("Nooooooo");
                }
            }

            //Solution 2

            if (List.Contains(7))
            {
                Console.WriteLine("Hooray");
            }
            else
            {
                Console.WriteLine("Nooooooo");
            }

            Console.ReadLine();
        }
    }
}
