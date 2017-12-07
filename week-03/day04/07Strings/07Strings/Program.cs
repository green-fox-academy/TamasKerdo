using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            Console.WriteLine(StringChanger("zxcvbnm,zxcvbnmzxcvbnmzxcvbnm"));
            Console.ReadLine();

        }

        static string StringChanger(string word)
        {
            var chars = word.ToCharArray();
            if (chars.Contains('x'))
            {
                int index = Array.IndexOf(chars, 'x');
                chars[index] = 'y';
                string modifiedWord = new string(chars);
                return StringChanger(modifiedWord);
            }
            else
            {
                return word;
            }
            
        }
    }
}
