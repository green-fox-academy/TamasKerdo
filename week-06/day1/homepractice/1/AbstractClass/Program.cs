using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person avetis = new Avetis("Avetis", "gkedyfg");
            Console.WriteLine(avetis.GetFullname());

            avetis.Greet();
        }
    }
}
