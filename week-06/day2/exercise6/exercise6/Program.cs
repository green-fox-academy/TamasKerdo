using System;
using System.Linq;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomWord = "liugwealfuglaukbf,aukbefuagf,vabc,ajwevfcyvWE,JDFYV,eix";            

            var randomWordDictionary = randomWord.ToCharArray()
                .GroupBy(n => n)
                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var dictionaryElement in randomWordDictionary)
            {
                Console.WriteLine($"character: {dictionaryElement.Key} frequency: {dictionaryElement.Value}");
            }
            Console.ReadLine();
        }
    }
}
