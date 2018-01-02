using System;
using System.Collections.Generic;
using System.Text;

namespace Model_stringed_instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            NumberOfStrings = 4;
            Name = "Duum-duum-duum";
        }
        public BassGuitar(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
            Name = "Duum-duum-duum";
        }

        public override void Play()
        {
            Console.WriteLine($"Bass Guitar, a {NumberOfStrings} -stringed instrument that {Name}");
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}
