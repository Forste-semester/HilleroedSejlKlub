// See https://aka.ms/new-console-template for more information

using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Globalization;

Console.WriteLine("Hello, World!");
Console.WriteLine("");


User user = new User();
Boat boat = new Boat("hund", "ddx", "sejlbåd", 43,1990,false);

Booking booking = new Booking(user, boat, DateOnly.Parse("01/12/2024"), 17);


BookingRepository bookingRepository = new BookingRepository();


bookingRepository.CreateBooking(booking);
bookingRepository.LeaveDock(1);
Console.WriteLine(DateTime.Now);
bookingRepository.GetAll();
bookingRepository.PrintAllBookings();

bookingRepository.UpdateBookingById(2);


