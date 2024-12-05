

﻿// See https://aka.ms/new-console-template for more information

using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Globalization;


BookingRepository bookingRepository = new BookingRepository();

bookingRepository.LeaveDock(1);

Console.WriteLine(bookingRepository.GetBooking(1));
