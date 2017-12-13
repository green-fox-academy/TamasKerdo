using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Letters
{
    public class Program
    {
        static void Main(string[] args)
        {            
            var lc = new LetterCount();
            lc.LetterCounter("cica");            
        }        
    }
    public class LetterCount
    {
        public Dictionary<char, int> LetterCounter(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Sort(charArray);
            var charList = charArray.ToList();
            Console.WriteLine(charList[0]);
            Console.ReadLine();
            var dict = new Dictionary<char, int>();
            int counter = 0;
            while (charList.Count != 0)
            {
                foreach (var element in charArray)
                {
                    if (element == charList[0])
                    {
                        counter++;
                    }
                }
                dict.Add(charList[0], counter);                                
                charList.RemoveRange(0, counter);
                counter = 0;
            }
            
            return dict;
        }
    }
}
