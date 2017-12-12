using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_my_number
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("give me a number between 1 and 100!");
            string input= Console.ReadLine();
            int guessedNumber;
            Int32.TryParse(input, out guessedNumber);
            

            Random rnd = new Random();
            int number = rnd.Next(1, 100);
            Console.WriteLine(number);
            int lifeCounter = 4;
            
            while ((lifeCounter>0))
            {
                if(guessedNumber > number)
                {
                    lifeCounter--;
                        
                    if (lifeCounter > 0)
                    {
                        Console.WriteLine("You managed to die!");
                    }
                }
                else if (guessedNumber < number)
                {
                    lifeCounter--;
                    if (lifeCounter > 0)
                    {
                        Console.WriteLine("Too High, You have " + lifeCounter + " life left!");
                    }
                    else
                    {
                        Console.WriteLine("You managed to die!");
                    }
                }
                else
                {
                    lifeCounter = 0;
                    Console.WriteLine("Yes the number is that i guessed is:" + guessedNumber);
                }
                
                Console.ReadLine();
            }
        }
    }
}
