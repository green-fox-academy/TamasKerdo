using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutA
{
    class TVRemote
    {
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
