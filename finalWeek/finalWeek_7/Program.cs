using System;
using System.Collections.Generic;
using System.Linq;

namespace finalWeek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<int> LetterFinder(string inputWord, char letterToFind)
        {
            var FoundLetters = new List<int>();
            var inputWordArray = new List<char>();
            inputWordArray = inputWord.ToCharArray().ToList();

            for (int i = 0; i < inputWordArray.Count; i++)
            {
                if (inputWordArray[i].Equals(letterToFind))
                {
                    FoundLetters.Add(i);
                }
            }

            return FoundLetters();
        }
    }
}
