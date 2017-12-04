using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideByZero
{
    class Program
    {
        static void Main(string[] args)
        {

            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0
            string a = Console.ReadLine();

            int b;
            Int32.TryParse(a, out b);
            numberTaker(b);
        }

        static void numberTaker(float number)
        {
            try
            {
                if (number == 0)
                {
                    throw new MyException();                    
                }
                Console.WriteLine(10/number);
            }
            catch (MyException)
            {
                Console.WriteLine("fail");
            }
            finally
            {
                Console.ReadLine();
            }

        }

        public class MyException : Exception

        {
            public MyException()
            {
                
            }

        }
    }
}
