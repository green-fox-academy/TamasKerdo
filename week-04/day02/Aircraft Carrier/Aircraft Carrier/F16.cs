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

        }

        public string getType()
        {
            return "Type F16";
        }

        public string getStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(getType());
            sb.Append("Ammo: ");
            sb.Append(CurrentAmmo);
            sb.Append(" Base Damage ");
            sb.Append(BaseDamage);
            sb.Append(" All Damage: ");
            sb.Append(BaseDamage * MaxAmmo);


            return sb.ToString();


            Type F35, Ammo: 10, Base Damage: 50, All Damage: 500
        }
    }
}
