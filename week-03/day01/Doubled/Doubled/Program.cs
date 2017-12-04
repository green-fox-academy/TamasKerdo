using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
            string filePath = @"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\Doubled\Doubled\double.txt";
            Decrypter(filePath);
        }

        static void Decrypter(string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                StreamWriter sw = new StreamWriter(@"D:\Greenfox Academy tananyag\repos\greenfox\TamasKerdo\week-03\day01\Doubled\Doubled\fixeddouble.txt");
                string line = "";
                StringBuilder sb = new StringBuilder();
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] lineArray = line.Split(new string[] { "  " }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string word in lineArray)
                        {
                            int i = 0;
                            char[] charArray = word.ToCharArray();

                            //char[] charArray = new char[word.Length];
                            //charArray = word.ToCharArray();
                            foreach (var character in charArray)
                            {
                                if (i % 2 == 0)
                                {

                                    sb.Append(character);
                                }
                                i++;
                            }
                            sb.Append(" ");
                            i++;
                        }
                        line = sb.ToString();
                        sw.WriteLine(line);
                        sb.Clear();
                    }
                     // szavak be lettek rakva egy tombbe       
                }
                sr.Close();
                sw.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
