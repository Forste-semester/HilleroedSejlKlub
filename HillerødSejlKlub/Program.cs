

﻿// See https://aka.ms/new-console-template for more information

using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Globalization;

#region BookingRepository Testing

BookingRepository bookingRepository = new BookingRepository();
bookingRepository.PrintAllBookings();

bookingRepository.LeaveDock(1);
bookingRepository.UpdateBookingById(6,2024,12,4,15);
bookingRepository.RemoveBookingById(4);
bookingRepository.LeaveDock(3);
Console.WriteLine(bookingRepository.GetBookingById(6));
Console.WriteLine(bookingRepository.GetAll());

bookingRepository.ReturnedToDock(1);
bookingRepository.PrintAllBookings();
#endregion
