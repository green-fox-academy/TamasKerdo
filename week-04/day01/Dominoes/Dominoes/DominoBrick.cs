using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    class DominoBrick
    {
        public int ASide { get; private set; }
        public int BSide { get; private set; }

        public DominoBrick(int ASide,int BSide)
        {
            this.ASide = ASide;
            this.BSide = BSide;
        }

        public void flipElement()
        {
            int helper = ASide;
            ASide = BSide;
            BSide = helper;
        }
    }
}
