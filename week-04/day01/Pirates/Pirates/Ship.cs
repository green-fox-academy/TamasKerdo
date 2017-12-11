using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Ship
    {
        public List<Pirates> CrewList  { get; private set; }
        public Pirates Captain { get; private set; }
        public bool isAlive { get; private set; }

        public void FillShip()
        {
            isAlive = true;
            var rn = new Random();
            Captain = new Pirates(0,rn.Next(1,3));
            CrewList = new List<Pirates>();
            CrewList.Add(Captain);
            
            for (int i = 1; i < rn.Next(1,101); i++)
            {
                
                CrewList.Add(new Pirates(i, rn.Next(2, 4)));
            }           
        }
        public int[] getShipStatus()
        {
            var returnStatusArray = new int[3];
            returnStatusArray[0] = Captain.IntoxicateState;

            foreach (var PirateMember in CrewList)
            {
                if (PirateMember.IsThePirateDead == true)
                {
                    returnStatusArray[1] = returnStatusArray[1]++;
                }                
            }

            if (Captain.IsThePirateDead == true)
            {
                returnStatusArray[2] = 1;
            }

            return returnStatusArray;
        }

        public int CalculateBattleScore()
        {
            int score = 0;
            foreach (var PirateMember in CrewList)
            {
                if (PirateMember.IsThePirateDead == true)
                {
                    score++;
                }
                
            }
            return score + Captain.IntoxicateState;
        }

        public void Battle(int theOtherShipScore)
        {
            var rn = new Random();
            if (theOtherShipScore > CalculateBattleScore())
            {
                if (CrewList.Count - 1 == 0)
                {
                    isAlive = false;
                    CrewList.RemoveRange(0, rn.Next(1, CrewList.Count - 1));
                }
                else
                {
                    CrewList.RemoveRange(0, rn.Next(1, CrewList.Count - 1));
                }
            }
            else
            {
                for (int i = 0; i < rn.Next(1, CrewList.Count); i++)
                {
                    CrewList[i].DrinkSomeRum();
                }
            }
        }

    }
}
