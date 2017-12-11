using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Lion = new Animal();
            Lion.Eat();
            Console.WriteLine(Lion.getEatStatus());
            Console.ReadLine();
        }
    }
}
