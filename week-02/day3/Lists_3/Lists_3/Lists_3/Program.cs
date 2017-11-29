using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.

            
            int i = 0;
            while (i!= far.Count)
            {
                far[i] = far[i] + "a";
                Console.WriteLine(far[i]);
                i++;
            }
            Console.Read();
        }
    }
}
