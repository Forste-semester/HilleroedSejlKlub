using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IBookingRepository
    {



        void CreateBooking(Booking booking);
        Booking GetBooking(int id);
        void RemoveBookingById(int id);
        Booking UpdateBookingById(int id, DateOnly year, DateOnly month, DateOnly day, DateTime returnHour);
        void PrintAllBookings();
    }
}
