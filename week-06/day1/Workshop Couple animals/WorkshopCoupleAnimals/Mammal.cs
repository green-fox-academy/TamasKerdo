using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCoupleAnimals
{
    class Mammal : Animal
    {
        public string FurColor { get; set; }

        public Mammal(string Name)
        {
            this.Name = Name;
        }

        public void DoMammalThings()
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
            return "doesn't lay eggs";
        }
    }
}
