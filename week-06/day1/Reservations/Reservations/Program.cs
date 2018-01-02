using System;

namespace Reservations
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = new Reservation();
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.WriteLine($"Booking# {res.GetCodeBooking()} for {res.GetDowBooking()}");
            Console.ReadLine();
        }
    }
}
