using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double firstSide = 20;

            double secondSide = 5;

            double thirdSide = 10;

            double surfaceArea = firstSide * secondSide * 2 + firstSide * thirdSide * 4;
            double volume = firstSide * secondSide * thirdSide;


            Console.WriteLine("Surface area:"+ surfaceArea);
            Console.WriteLine("Volume:" + volume);
            Console.ReadLine();

        }
    }
}
