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



       // public void CreateBooking(Booking booking);
       // public Booking GetBooking(int id);
        public void RemoveBookingById(int id);
        public void UpdateBookingById(int id);
        public void PrintAllBookings();
    }
}
