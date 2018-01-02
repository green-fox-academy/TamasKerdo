using System;
using System.Collections.Generic;
using System.Text;

namespace Model_stringed_instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            NumberOfStrings = 4;
            Name = "Screech";
        }

        public override void Play()
        {
            Console.WriteLine($"Violin, a {NumberOfStrings}-stringed instrument that {Name}");
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}