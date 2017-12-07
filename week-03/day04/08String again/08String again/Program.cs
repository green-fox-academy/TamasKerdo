using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08String_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            
            Console.WriteLine(StringAgain("xzcvzvbxcxbzbnznxvxc"));
            Console.ReadLine();
        }

        static string StringAgain(string word)
        {
            var characterArray = word.ToCharArray();
            
            if (characterArray.Contains('x'))
            {
                var newCharacterArray = new char[characterArray.Length - 1];
                int index = Array.IndexOf(characterArray, 'x');
                int xFinder = 0;
                for (int i = 0; i < characterArray.Length - 1; i++)
                {
                    if ((characterArray[xFinder] == 'x')&&( i == xFinder))
                    {
                        xFinder++; ;
                    }                    
                    newCharacterArray[i] = characterArray[xFinder];
                    xFinder++;
                }
                string newWord = new string(newCharacterArray);
                return StringAgain(newWord);
            }
            else
            {
                return word;
            }           

        }
    }
}
