using System;
using System.Collections.Generic;
using System.Text;

namespace Model_stringed_instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            NumberOfStrings = 6;
            Name = "Twang";
        }

        public ElectricGuitar(int NumberOfStrings)
        {
            this.NumberOfStrings = NumberOfStrings;
            Name = "Twang";
        }

        public override void Play()
        {
            Console.WriteLine($"Electric Guitar, a {NumberOfStrings}-stringed instrument that {Name}");
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }
    }
}