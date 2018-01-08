using System;
using System.Linq;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomWord = "hlasehfhHUHjpjpojJPJpojIhlbKBkugLUFKykjyfKJUGFuglUKGkugUFuf,ujv,JV,juv,KUkuv,kuv";
            randomWord.ToCharArray().Where(x => char.IsUpper(x)).ToList().ForEach(x=> Console.WriteLine(x));            

            Console.ReadLine();
        }
    }
}
