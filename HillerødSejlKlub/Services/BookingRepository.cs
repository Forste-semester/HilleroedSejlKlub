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

        private Dictionary<int, Booking> _bookings;


        public BookingRepository() 
        {
            _bookings = new Dictionary<int, Booking>();
        }


        public void CreateBooking(Booking booking)
        {
            _bookings.Add(booking.Id, booking);
        }

        public Booking GetBooking(int id)
        {
            return _bookings[id];
        }

        public void RemoveBookingById(int id)
        {
            if (_bookings.ContainsKey(id))
            { 
            _bookings.Remove(id);
            }
        }

        public void UpdateBookingById(int id)
        {
            try
            {
                if (!_bookings.ContainsKey(id))
                {
                    throw new Exception($"No booking found with ID {id}.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
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

        public void LeaveDock(int id)
        {
            Booking booking = _bookings[id];
            if (_bookings.ContainsKey(id))
            {
               booking.AtSea = true;
            }
        }


        public List<Booking> ListOfBoatsAtSea()
        {
            foreach (var item in _bookings.Values)
            {
                if (item.AtSea == true)
                {
                    Console.WriteLine(item);
                }
            }
            return _bookings.Values.ToList();
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
