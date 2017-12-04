using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

            FileReaderMethod();
        }

        static void FileReaderMethod()
        {
            try
            {
                StreamReader sr = new StreamReader(@"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\PrintEachLine\PrintEachLine\my-file.txt");
                string line= "";
                
                while (line != null)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                sr.Close();
            }
            
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
