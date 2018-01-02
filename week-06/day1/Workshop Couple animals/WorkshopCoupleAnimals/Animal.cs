using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopCoupleAnimals
{
    abstract class Animal
    {
        //it has name, age field
        //it has Greet() and WantChild() methods
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        abstract public void Greet();
        abstract public string WantChild();
        abstract public void Move();
        abstract public void DoAnimalThings();

        public string GetName()
        {
            return Name;
        }

    }
}
