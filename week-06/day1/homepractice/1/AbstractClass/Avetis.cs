using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Avetis : Person
    {
        public Avetis(string firstname, string lastname) : base(firstname, lastname)
        {

        }

        public override void Greet()
        {
            Console.WriteLine("Hi there!");
        }
    }
}
