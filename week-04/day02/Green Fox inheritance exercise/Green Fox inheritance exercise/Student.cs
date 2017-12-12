using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_inheritance_exercise
{
    class Student : Person
    {
        //Create a Student class that has the same fields and methods as the Person class, and has the following additional

        //fields:
        //previousOrganization: the name of the student’s previous company / school
        //skippedDays: the number of days skipped from the course
        //methods:
        //GetGoal(): prints out "Be a junior software developer."
        //Introduce(): "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
        //SkipDays(numberOfDays): increases skippedDays by numberOfDays
        //The Student class has the following constructors:

        //Student(name, age, gender, previousOrganization) : beside the given parameters, it sets skippedDays to 0
        //Student() : sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0

        public string previousOrganization { get; set; }
        public int skippedDays { get; set; }


        public Student(string Name, int Age, string Gender, string previousOrganization) : base(Name, Age, Gender)
        {
            this.previousOrganization = previousOrganization;
            skippedDays = 0;
        }

        public Student()
        {
            
        }


        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name+ ", a " + Age + " year old " + Gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
