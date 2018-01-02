using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Student : Person, ICloneable
    {

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
            Console.WriteLine("Hi, I'm" + Name + ", a " + Age + " year old " + Gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }

        public Student Clone()
        {
            Student clonedStudent = new Student(Name, Age, Gender, previousOrganization);
            return clonedStudent;
        }
    }
}

