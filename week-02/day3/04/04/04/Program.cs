using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText


            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            StringBuilder builder = new StringBuilder();
            builder.Append("My todo\n");
            builder.Append(todoText);
            builder.Append(" - Download games\n");
            builder.Append(" - Diablo\n");
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
