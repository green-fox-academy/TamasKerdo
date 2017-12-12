using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_inheritance_exercise
{
    class Person
    {
        //name: the name of the person
        //age: the age of the person(whole number)
        //gender: the gender of the person(male / female)

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        //Person(name, age, gender)
        //Person() : sets name to Jane Doe, age to 30, gender to female

        public Person(string Name,int Age,string Gender)
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
            Console.WriteLine("Hi, I'm name, a age year old gender.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
