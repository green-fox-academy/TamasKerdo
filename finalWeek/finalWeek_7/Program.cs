using System;
using System.Collections.Generic;
using System.Linq;

namespace finalWeek_7
{
    class Program
    {
        static void Main(string[] args)
        {

            char letter = 'a';
            string word = "almafa";

            foreach (var letterpositions in LetterFinder(word, letter))
            {
                Console.WriteLine(letterpositions);
            }
            Console.ReadLine();
        }

        public static List<int> LetterFinder(string inputWord, char letterToFind)
        {
            var LetterPositions = new List<int>();
            var inputWordArray = new List<char>();
            inputWordArray = inputWord.ToCharArray().ToList();

            for (int i = 0; i < inputWordArray.Count; i++)
            {
                if (inputWordArray[i].Equals(letterToFind))
                {
                    LetterPositions.Add(i);
                }
            }

            return LetterPositions;
        }
    }
}
