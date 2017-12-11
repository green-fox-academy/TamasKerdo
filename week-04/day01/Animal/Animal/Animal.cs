using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public int hunger { get; private set; }
        public int thirst { get; private set; }

        public Animal()
        {
            hunger = 50;
            thirst = 50;
        }

        public void Eat()
        {
            hunger--;
        }
        public void Drink()
        {
            thirst--;
        }
        public void Play()
        {
            hunger++;
            thirst++;
        }

        public int getEatStatus()
        {
            return hunger;
        }
    }
}
