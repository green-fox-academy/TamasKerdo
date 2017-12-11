using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class BattleApp
    {
        public Ship Ship1 { get; set; }
        public Ship Ship2 { get; set; }

        public BattleApp()
        {
            this.Ship1 = new Ship();
            this.Ship2 = new Ship();

            Ship1.FillShip();
            Ship2.FillShip();
        }

        public List<int[]> BattleOfTwoShips()
        {
            var returnList = new List<int[]>();
            Ship2.Battle(Ship1.CalculateBattleScore());
            returnList.Add(Ship1.getShipStatus());
            returnList.Add(Ship2.getShipStatus());

            return returnList;
        }
    }
}
