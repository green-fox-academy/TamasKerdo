using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOsephus_problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Josephus problem \nPlease give me the number of the circle");
            int circlePointNumber = Console.Read();


            var circlePointList = new List<Dictionary<string, object>>();

            for (int i = 0; i < circlePointNumber; i++)
            {
                var josephusCircle = new Dictionary<string, object>();

                josephusCircle.Add("position", i);

                if (i + 1 == circlePointNumber)
                {
                    josephusCircle.Add("nextPosition", 0);
                }
                else
                {
                    josephusCircle.Add("nextPosition", i+1);
                }
                josephusCircle.Add("status","alive");

                circlePointList.Add(josephusCircle);
            }




        }
    }
}
