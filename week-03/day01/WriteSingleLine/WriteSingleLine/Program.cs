using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {

            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            FileOpener(@"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day10\WriteSingleLine\WriteSingleLine\my-file.txt","Tamas");


        }

        static void FileOpener(string fileName, string myName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine(myName);
                sw.Close();
            }
            catch (Exception)
            {

                Console.WriteLine("Unable to write file: my-file.txt");

            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
