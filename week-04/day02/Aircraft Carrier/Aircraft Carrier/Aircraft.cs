using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Carrier
{
    class Aircraft
    {
        public int MaxAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int CurrentAmmo { get; set; }
        public string AircraftType { get; set; }
        
        public Aircraft()
        {
            CurrentAmmo = 0;
        }
        
        public int Fight()
        {
            CurrentAmmo = 0;
            return BaseDamage * CurrentAmmo;            
        }

        public string getType()
        {
            return AircraftType;
        }

        public string getStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AircraftType);
            sb.Append("Ammo: ");
            sb.Append(CurrentAmmo);
            sb.Append(" Base Damage ");
            sb.Append(BaseDamage);
            sb.Append(" All Damage: ");
            sb.Append(BaseDamage * MaxAmmo);
            return sb.ToString();
        }

        public int Refill(int InputAmmo)
        {
            if (InputAmmo > MaxAmmo-CurrentAmmo)
            {
                CurrentAmmo = MaxAmmo;
                return InputAmmo - (MaxAmmo - CurrentAmmo);
            }
            else 
            {
                CurrentAmmo +=InputAmmo;
                return 0;
            }
        }                
    }
}
