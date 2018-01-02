using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCoupleAnimals
{
    class Frog : Reptile
    {
        public Frog(string Name) : base(Name)
        {
        }

        public override string WantChild()
        {
            return "lays eggs";
        }
    }
}
