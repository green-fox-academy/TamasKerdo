using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string file = "my-file.txt";
            string newFileName = "rekettye.txt";
            string fileLocations = @"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\CopyFile\CopyFile\";
            bool succeed = FileContentCopier(file, newFileName, fileLocations);
            Console.WriteLine(succeed);
            Console.ReadLine();
        }

        static bool FileContentCopier(string file, string newFileName, string fileLocations)
        {
            bool copySucceed = false;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(fileLocations);
                sb.Append(file);
                StreamReader sr = new StreamReader(sb.ToString());
                sb.Clear();

                sb.Append(fileLocations);
                sb.Append(newFileName);
                StreamWriter sw = new StreamWriter(sb.ToString(), true);
                string line = "";
                while (line != null)
                {
                    line = sr.ReadLine();
                    sw.WriteLine(line);
                }
                copySucceed = true;
                sr.Close();
                sw.Close();
            }
            catch (Exception)
            {

                copySucceed = false;
            }
            return copySucceed;
        }
    }
}
