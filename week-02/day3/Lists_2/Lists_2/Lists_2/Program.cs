using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> {  "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> {, "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            
            while(!(girls.Count==0)&&!(boys.Count==0))
            {
                if (girls.Count != 0)
                {
                    order.Add(girls[0]);
                    girls.RemoveAt(0);
                }
                if (boys.Count != 0)
                {
                    order.Add(boys[0]);
                    boys.RemoveAt(0);
                }
                                   
                
            }
            for (int i = 0; i < order.Count; i++)
            {
                Console.WriteLine(order[i]);
            }


            Console.ReadLine();
        }
    }
}
