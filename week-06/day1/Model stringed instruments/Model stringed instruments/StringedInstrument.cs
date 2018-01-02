using System;
using System.Collections.Generic;
using System.Text;

namespace Model_stringed_instruments
{
    abstract class StringedInstrument : Instrument
    {
        //introduces numberOfStrings and
        //Sound() method what's implementation is yet unknown
        //but with the help of the Sound() the Play() method is fully implementable

        public int NumberOfStrings { get; set; }

        abstract public void Sound();        
    }
}
