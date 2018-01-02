using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCoupleAnimals
{
    class Bird : Animal
    {
        public string PlumeColor { get; set; }

        public Bird(string Name)
        {
            this.Name = Name;
        }

        public void DoBirdThings()
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
