using System;

namespace finalWeek_7
{
    class Program
    {
        static void Main(string[] args)
        {

            char letter = 'a';
            string word = "almafa";
            var letterPositionFinder = new LetterPositionFinder();

            foreach (var letterpositions in letterPositionFinder.LetterFinder(word, letter))
            {
                Console.WriteLine(letterpositions);
            }
            Console.ReadLine();
        }
        
    }
}
