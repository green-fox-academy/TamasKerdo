using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations
{
    class Reservation : IReservationy
    {     
        public string GetCodeBooking()
        {
            Random rand = new Random();

            string Alphabet =
            "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        
            char[] chars = new char[8];
            for (int i = 0; i < 8; i++)
            {
                chars[i] = Alphabet[rand.Next(Alphabet.Length)];
            }
            string s = new string(chars);
            return s;
        }

        public string GetDowBooking()
        {
            Random rand = new Random();
            string[] daysOfTheWeek = new string[] { "mon", "tue", "wed", "thi", "fri", "sat", "sun" };

            return daysOfTheWeek[rand.Next(0, 7)];
        }
    }
}


