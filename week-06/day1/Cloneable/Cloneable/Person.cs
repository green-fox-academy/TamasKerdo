using System;
using System.Collections.Generic;
using System.Text;

namespace Cloneable
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }
        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        //Introduce(): prints out "Hi, I'm name, a age year old gender."
        //GetGoal(): prints out "My goal is: Live for the moment!"

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + ".");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
