using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            int fileLine = FileLineCounterMethod("my-file.txt");
            Console.WriteLine(fileLine);
            Console.ReadLine();
            
        }


        static int FileLineCounterMethod(string fileName)
        {
            StringBuilder sb = new StringBuilder();
            string filePlace = @"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\CountLines\CountLines\";
            sb.Append(filePlace);
            sb.Append(fileName);
            fileName = sb.ToString();
            int lineNumber = 0;
            try
            {
                StreamReader st = new StreamReader(fileName);
                string line = "";

                while (line != null)
                {
                    line = st.ReadLine();
                    lineNumber++;
                }
                lineNumber--;
                st.Close();
            }
            catch (Exception)
            {
                lineNumber = 0;
            }
            
             return lineNumber;
                        
        }
    }
       
}
