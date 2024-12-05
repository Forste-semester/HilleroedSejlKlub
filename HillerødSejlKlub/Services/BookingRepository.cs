using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class BookingRepository : IBookingRepository
    {
        #region Instance fields
        private Dictionary<int, Booking> _bookings;
        #endregion
        #region Constructor
        public BookingRepository()
        {
            _bookings = new Dictionary<int, Booking>(BookingCollection.BookingData);
        }
        #endregion
        #region CRUD Methods
        public void CreateBooking(Booking booking)
        {
                _bookings.Add(booking.Id, booking);
        }

        public Booking GetBooking(int bookingId)
        {
            try
            {
                if (_bookings.ContainsKey(bookingId))
                {
                    return _bookings[bookingId];
                }
                else
                {
                    throw new KeyNotFoundException($"No bookings found with ID:{bookingId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void RemoveBookingById(int bookingId)
        {
            if (_bookings.ContainsKey(bookingId))
            {
                _bookings.Remove(bookingId);
            }
        }

        public Booking UpdateBookingById(int bookingId, DateOnly year, DateOnly month, DateOnly day, DateTime returnHour)
        {
            if (_bookings.ContainsKey(bookingId))
            {
                _bookings[bookingId].BookingDate = DateOnly.Parse($"{year}/{month}/{day}");
                _bookings[bookingId].ReturnTime = returnHour;
            }
            return null;
        }


        public List<Booking> GetAll()
        {
            return _bookings.Values.ToList();
        }

        public void PrintAllBookings()
        {
            foreach (Booking booking in _bookings.Values)
            {
                Console.WriteLine(booking.ToString());
            }
        }

        #endregion

        public List<Booking> ListOfBookingsAtSea()
        {
            Console.WriteLine("=====================================================\n\t\tList of bookings at sea\n=====================================================");
            foreach (var item in _bookings.Values)
            {
                if (item.AtSea == true)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("=====================================================");
            return null;
        }
        public void LeaveDock(int id)
        {
            Booking booking = _bookings[id];
            if (_bookings.ContainsKey(id))
            {
                booking.AtSea = true;
            }
        }

        public void ReturnedToDock(int id)
        {
            Booking booking = _bookings[id];
            if (_bookings.ContainsKey(id))
            {
                booking.AtSea = false;
            }
        }
    }
}
