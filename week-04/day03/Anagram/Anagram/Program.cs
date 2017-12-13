using System;

namespace Anagram
{
    public class Angram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Angram a = new Angram();
           
            Console.ReadLine();
        }

        public Boolean AngramChecker(string word1, string word2)
        {
            bool anagramReturn = true;
            char[] array1 = word1.ToCharArray();
            char[] array2 = word2.ToCharArray();

            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            Console.Write(array1[i]);
                            Console.Write(array2[j]);
                            Console.WriteLine();
                            array1[i] = '0';
                            array2[j] = '0';                            
                            break;
                        }
                    }
                }
                foreach (var item in array1)
                {
                    if (item != '0')
                    {
                        anagramReturn = false;
                    }
                }
            }
            else
            {
                anagramReturn = false;
            }
            return anagramReturn;
        }
    }
}
