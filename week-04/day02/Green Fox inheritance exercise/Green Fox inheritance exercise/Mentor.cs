using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_inheritance_exercise
{
    class Mentor : Person
    {
        //Create a Mentor class that has the same fields and methods as the Personclass, and has the following additional

        //fields:
        //level: the level of the mentor(junior / intermediate / senior)
        //methods:
        //GetGoal(): prints out "Educate brilliant junior software developers."
        //Introduce(): "Hi, I'm name, a age year old gender level mentor."
        //The Mentor class has the following constructors:

        //Mentor(name, age, gender, level)
        //Mentor() : sets name to Jane Doe, age to 30, gender to female, level to intermediate

        public string Level { get; set; }

        public Mentor(string Name,int Age, string Gender,string Level) : base(Name, Age, Gender)
        {
            this.Level = Level;            
        }

        public Mentor()
        {
           
        }

        public new void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " " + Level + " mentor.");
        }
    }
}
