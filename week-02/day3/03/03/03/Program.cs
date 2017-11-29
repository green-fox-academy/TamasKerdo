using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)


            int part1 = quote.IndexOf(" you");
         
            var builder = new StringBuilder();
            builder.Append(quote);
            builder.Insert(part1," always takes longer than");



            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}
