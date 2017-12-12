using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_inheritance_exercise
{
    class Sponsor : Person
    {

        //Create a Sponsor class that has the same fields and methods as the Personclass, and has the following additional

        //fields:
        //company: name of the company
        //hiredStudents: number of students hired
        //method:
        //Introduce(): "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
        //Hire(): increase hiredStudents by 1
        //GetGoal(): prints out "Hire brilliant junior software developers."
        //The Sponsor class has the following constructors:

        //Sponsor(name, age, gender, company) : beside the given parameters, it sets hiredStudents to 0
        //Sponsor() : sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0

        public string Company { get; set; }
        public int HiredStudents { get; set; }

        public Sponsor(string Name, int Age, string Gender, string Company) : base(Name, Age, Gender)
        {
            HiredStudents = 0;
            this.Company = Company; 
        }

        public Sponsor()
        {
            HiredStudents = 0;
            Company = "Google";
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far.");
        }

        public new void Hire()
        {
            HiredStudents++;
        }

        public new void GetGoal()
        {

        }
    }
}
