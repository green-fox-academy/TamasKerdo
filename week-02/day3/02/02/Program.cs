using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";

            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crutial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            url = url.Replace("bots", "odds");
            Console.WriteLine(url);
            url = url.Replace("odds", "bots");

            int index;
            index = url.LastIndexOf("bots");
            Console.WriteLine(index);
            
            Console.WriteLine(index);
            Console.WriteLine(url.Remove(url.LastIndexOf("bots"), 3));
            Console.WriteLine(url.Insert(url.Length, "bots"));

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
