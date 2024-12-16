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
        #region #Methods
        void CreateBooking(Booking booking);
        Booking GetBookingById(int id);
        void RemoveBookingById(int id);
        Booking UpdateBookingById(int bookingId,string location, int year, int month, int day, int returnHour);
        Dictionary<int, Booking> GetAll();
        void PrintAllBookings();
        #endregion
    }
}
