using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates
{
    class Pirates
    {
        public int IntoxicateState { get; private set; }
        public bool IsThePirateDead { get; private set; }

        public Pirates()
        {
            IntoxicateState = 0;
            IsThePirateDead = false;
        }

        public void DrinkSomeRum()
        {
            IntoxicateState++;
        }

        public void HowsItGoingMate()
        {
            if (IntoxicateState > 4 && IsThePirateDead != true)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else if (IntoxicateState <= 4 && IsThePirateDead != true)
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
            }
            else
            {
                Console.WriteLine("he's dead");
            }
        }

        public void Die()
        {
            IsThePirateDead = true;
        }
        public int Brawl(int DamageOfTheOtherPirate)
        {
            var rn = new Random();
            int damage = rn.Next(1, 4);
            if (DamageOfTheOtherPirate >= damage)
            {
                Die();
            }
            return damage;
        }
    }
}
