using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            var battleOfBalaton = new BattleApp();

            foreach (var shipList in battleOfBalaton.BattleOfTwoShips())
            {
                foreach (var statusData in shipList)
                {
                    Console.WriteLine(statusData);
                }
            }
            Console.Read();

        }
    }
}
