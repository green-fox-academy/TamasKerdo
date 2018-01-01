using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutA
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is off");
        }

        public void On()
        {
            Console.WriteLine("The TV is on");
        }

        public void VolumeDown()
        {
            if (Volume!=0)
            {
                Volume--;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }

        public void VolumeUp()
        {
            if (Volume != 100)
            {
                Volume++;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }
    }
}
