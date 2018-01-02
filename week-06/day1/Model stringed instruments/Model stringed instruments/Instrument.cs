using System;
using System.Collections.Generic;
using System.Text;

namespace Model_stringed_instruments
{
    abstract class Instrument
    {
        //We start with a base, abstract class Instrument.

        //it reserves(e.g. protected) the name of the instrument
        //it should provide a Play() method.

        protected string Name { get; set; }

        abstract public void Play();
    }
}
