using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

            string path = @"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\WriteMultipleLines\WriteMultipleLines\my-file.txt";
            string word = "rotacios-kapa";
            int number = 100;
            MultipleFileLineWriter(path, word, number);
        }

        static void MultipleFileLineWriter(string path, string word, int number)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                string line="";
                for (int i = 0; i < number; i++)
                {
                    sw.WriteLine(word);
                }
                sw.Close();
                                   
                
            }
            catch (Exception)
            {

                
            }
        }
    }
}
