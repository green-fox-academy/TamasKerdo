using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCoupleAnimals
{
    class Reptile :Animal
    {
        public string OutlookColor { get; set; }


        public Reptile(string Name)
        {
            this.Name = Name;
        }

        public void DoReptileThings()
        {
            throw new NotImplementedException();
        }

        public override void DoAnimalThings()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
        public override string WantChild()
        {
            return "lays eggs";
        }
    }
}
