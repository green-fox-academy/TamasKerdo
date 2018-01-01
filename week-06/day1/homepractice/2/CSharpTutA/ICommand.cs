using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpTutA
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}
