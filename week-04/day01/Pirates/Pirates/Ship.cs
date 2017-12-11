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

        public Ship()
        {

        }

        public void FillShip()
        {
            
            Captain = new Pirates(0);

            var rn = new Random();
            for (int i = 1; i < rn.Next(1,101); i++)
            {
                
                CrewList[i] = new Pirates(i);
            }
            

        }

    }
}
