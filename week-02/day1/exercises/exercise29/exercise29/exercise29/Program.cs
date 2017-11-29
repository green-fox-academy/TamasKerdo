using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise28
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("number of the rows of the tringle:");
            string input = Console.ReadLine();
            int triangleRow;
            Int32.TryParse(input, out triangleRow);

            for (int i = 0; i < triangleRow; i++)
            {

                for (int j = 0; j < triangleRow - 1; j++)
                {
                    if (i + j >= triangleRow - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("*");
                for (int j = 0; j < triangleRow - 1; j++)
                {
                    if (i + j >= triangleRow - 1)
                    {
                        Console.Write("*");
                    }


                }
                Console.WriteLine();

            }



            for (int i = 0; i < triangleRow; i++)
            {

                for (int j = 0; j < triangleRow - 1; j++)
                {
                    if (j<i+1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }




                for (int j = 0; j < triangleRow - 1; j++)
                {
                    if (triangleRow-j-i-1>0)
                    {
                        Console.Write("*");
                    }
                    
                }
                
                Console.WriteLine();
            }



            Console.ReadLine();

        }
    }
}
    

