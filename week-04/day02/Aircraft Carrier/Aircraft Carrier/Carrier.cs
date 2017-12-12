using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircraft_Carrier
{
    class Carrier
    {
        public int Ammo { get; set; }
        public int HealthPoints { get; set; }
        public List<Aircraft> AircraftList { get; set; }

        public Carrier(int Ammo, int HealthPoints)
        {
            AircraftList = new List<Aircraft>();
            this.Ammo = Ammo;
            this.HealthPoints = HealthPoints;
        }

        public void AddAircraft(Aircraft plane)
        {
            AircraftList.Add(plane);
        }

        public int Fill(int AmmoInStorage)
        {
            try
            {
                if (AmmoInStorage == 0)
                {
                    throw new NoAmmoInRepositoryException();
                }
            }
            catch (Exception)
            {
                Console.ReadLine();
            }

            if (AmmoInStorage > 0)
            {
                int NeededAmmo = 0;
                foreach (var plane in AircraftList)
                {
                    NeededAmmo += plane.CurrentAmmo;
                }

                if (AmmoInStorage < NeededAmmo)
                {
                    foreach (var plane in AircraftList)
                    {
                        if (plane.getType() == "Type F35" && AmmoInStorage != 0)
                        {
                            AmmoInStorage = plane.Refill(AmmoInStorage);
                        }
                    }
                }
                else
                {
                    foreach (var plane in AircraftList)
                    {
                        AmmoInStorage = plane.Refill(AmmoInStorage);
                    }
                }
            }
            return AmmoInStorage;
        }

        public void Fight()
        {
            var EnemyCarrier = new Carrier(400, 5000);

            int FullDamage = 0;
            foreach (var plane in AircraftList)
            {
                FullDamage += plane.CurrentAmmo;
            }
            EnemyCarrier.HealthPoints = EnemyCarrier.HealthPoints - FullDamage;
        }

        public void GetStatus()
        {
            if (HealthPoints < 1)
            {
                Console.WriteLine("It's dead Jim :(");
            }
            else
            {
                int FullDamage = 0;
                foreach (var plane in AircraftList)
                {
                    FullDamage += plane.CurrentAmmo;
                }
                Console.WriteLine("health of our carrier: " + HealthPoints + "Aircraft count: " + AircraftList.Count + "Ammo Storage: " + Ammo + "Total damage: " + FullDamage);
                foreach (var plane in AircraftList)
                {
                    Console.WriteLine(plane.getStatus());
                }
            }
        }
    }
}


class NoAmmoInRepositoryException : Exception
{
    public NoAmmoInRepositoryException()
    {
        String.Format("There is no ammo in the repo!!");
    }    
}
