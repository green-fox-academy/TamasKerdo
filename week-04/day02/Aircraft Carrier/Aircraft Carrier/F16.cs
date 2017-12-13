using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Carrier 
{
    class F16 : Aircraft
    {
        public F16()
        {
            BaseDamage = 30;
            MaxAmmo = 8;
            AircraftType = "Type F16";
        }        
    }
}
