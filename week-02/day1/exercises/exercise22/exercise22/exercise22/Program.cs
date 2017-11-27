using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            int outt = 0;

            // if w is even increment out by one

            string input = Console.ReadLine();
            float w;
            float.TryParse(input, out w);
            w = w % 2;
            if (w == 0)
            {
               outt++;
            }

            Console.WriteLine(outt);

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            if (b > 10 && b < 20)
            {
                out2 = "Sweet!";
            }
            else if (b < 10)
            {
                out2 = "More!";
            }
            else if (b > 20)
            {
                out2 = "Less!";
            }





            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same


            if ((credits >= 50) && (isBonus == false))
            {
                c--;
                c--;
            }

            else if ((credits < 50) && (isBonus == false))
            {
                c--;
            }

           
           

            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"
            float floatd = d;
            
            floatd = floatd % 4;

            if ((floatd == 0) && (time <= 200))
            {
                out3 = "check";
            }

            else if (time > 200)
            {
                out3 = "Time out";
            }

            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);
            }
    }
}
