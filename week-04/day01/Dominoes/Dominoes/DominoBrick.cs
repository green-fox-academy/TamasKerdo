using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominoes
{
    class DominoBrick : IPrintable
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

        public void PrintAllFields(List<DominoBrick> DominoList)
        {
            foreach (var DominoElement in DominoList)
            {
                Console.WriteLine($"{DominoElement.ASide} { DominoElement.BSide}");
                Console.WriteLine();
            }
        }
    }
}
