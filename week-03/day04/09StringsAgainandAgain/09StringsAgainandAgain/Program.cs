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

            if (characterArray.Contains('*'))
            {
                var newCharacterArray = new char[characterArray.Length +1];
                int index = Array.LastIndexOf(characterArray, '*');
                int xFinder = 0;
                for (int i = 0; i < characterArray.Length - 1; i++)
                {
                    if ((i == index) && (characterArray[index+2]< characterArray.Length))
                    {
                        xFinder+=2;
                    }
                    newCharacterArray[xFinder] = characterArray[i];
                    xFinder++;
                }
                string newWord = new string(newCharacterArray);
                return StringAgain(newWord);
            }
            else
            {
                var newCharacterArray = new char[characterArray.Length + 1];
                
                int helper = 0;
                for (int i = 0; i < characterArray.Length - 1; i++)
                {
                    if (i==1)
                    {
                        newCharacterArray[i] = '*';
                        helper++;
                    }
                    newCharacterArray[i] = characterArray[helper];
                    helper++;
                }
                string newWord = new string(newCharacterArray);
                return StringAgain(newWord);
            }
                       

        }
    }
}
