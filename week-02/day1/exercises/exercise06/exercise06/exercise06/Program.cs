using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int dayCodeInHours = 6;
            int semesterlenghtInWeeks = 17;
            int weeklyCodingHours = dayCodeInHours * 5 * semesterlenghtInWeeks;
            Console.WriteLine(weeklyCodingHours);

            float fullSemesterHours = 7 * 24 * 17;
            Console.WriteLine(fullSemesterHours);
            float percentageOfWorkHours = ((52*semesterlenghtInWeeks) / fullSemesterHours) * 100;
            Console.WriteLine(percentageOfWorkHours);
            Console.ReadLine();
        }
    }
}
