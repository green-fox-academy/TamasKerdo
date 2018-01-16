using System;

namespace exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[15];
            c[0] = 'O';
            c[1] = 'n';
            c[2] = 'l';
            c[3] = 'y';
            c[4] = ' ';
            c[5] = 'T';
            c[6] = 'h';
            c[7] = 'e';
            c[8] = ' ';
            c[9] = 'L';
            c[10] = 'o';
            c[11] = 'n';
            c[12] = 'e';
            c[13] = 'l';
            c[14] = 'y';

            string word = new string(c);
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
