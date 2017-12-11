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
            var rn = new Random();

        }

    }
}
