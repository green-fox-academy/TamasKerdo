using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Josephus_problem02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me the pointnumber of the circle:");

            string input = Console.ReadLine();


            //initialize the circle
            int circlePointNumber = 0;
            Int32.TryParse(input, out circlePointNumber);
            int[] josephusCircle = new int[circlePointNumber];

            for (int i = 0; i < circlePointNumber; i++)
            {
                josephusCircle[i] = i + 1;
                if (i == circlePointNumber - 1)
                {
                    josephusCircle[i] = 0;

                }
                
            }
            // Run the game
            circlePointNumber = josephusCircle.Length;
            int pointer = 0;
            while (circlePointNumber != 1)
            {
                           
             josephusCircle[pointer] = josephusCircle[josephusCircle[pointer]];
             
             //josephusCircle[josephusCircle[pointer]] = 0;
             
             pointer = josephusCircle[pointer];
             
             circlePointNumber--;
             
            }

            Console.WriteLine(pointer+1);
            Console.ReadLine();
        }
    }
}
