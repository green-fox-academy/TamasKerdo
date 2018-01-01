using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutA
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}
