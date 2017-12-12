using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_inheritance_exercise
{
    class PallidaClass
    {
        //Create a PallidaClass class that has the following

        //fields:
        //className: the name of the class
        //students : a list of Students
        //mentors: a list of Mentors
        //methods:
        //AddStudent(Student): adds the given Student to students list
        //AddStudent(Student): adds the given Mentor to mentors list
        //Info(): prints out "Pallida className class has students.size students and mentors.size mentors."
        //The PallidaClass class has the following constructors:

        //PallidaClass(className) : beside the given parameter, it sets students and mentors as empty lists

        public string className { get; set; }
        public List<Student> StudentList { get; set; }
        public List<Mentor> MentorList  { get; set; }

        public PallidaClass(string className)
        {
            this.className = className;
            

        }

        public void AddStudent(Student OneStudent)
        {
            StudentList.Add(OneStudent);
        }

        public void AddMentor(Mentor OneMentor)
        {
            MentorList.Add(OneMentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida" + className + "class has " + StudentList.Count + " students and " + MentorList.Count + " mentors.");
        }

    }
}
