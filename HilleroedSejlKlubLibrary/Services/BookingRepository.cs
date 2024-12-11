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

        public Booking GetBookingById(int bookingId)
        {
            try
            {
                if (_bookings.ContainsKey(bookingId))
                {
                    return _bookings[bookingId];
                }
                else
                {
                    throw new KeyNotFoundException($"#Error: No bookings with ID: {bookingId}");
                }
            }
            catch (KeyNotFoundException ex) 
            { 
            Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void RemoveBookingById(int bookingId)
        {
            try
            {
                if (_bookings.ContainsKey(bookingId))
                {
                    _bookings.Remove(bookingId);
                }
                else
                {
                    throw new KeyNotFoundException($"#Error: No bookings with ID: {bookingId}");
                }
            }
            catch (KeyNotFoundException ex) 
            { 
            Console.WriteLine(ex.Message);
            }
        }

        //den her metode updaterer det nuværende objekt. Du kan opdatere, Year, Month, Day (datoen) også kan du ændre returnHour
        public Booking UpdateBookingById(int bookingId,string location, int year, int month, int day, int returnHour)
        {
            try
            {
                if (_bookings.ContainsKey(bookingId))
                {
                    _bookings[bookingId].Location = location;
                    _bookings[bookingId].BookingDate = DateOnly.Parse($"{year}/{month}/{day}");
                    _bookings[bookingId].ReturnTime = new DateTime(_bookings[bookingId].BookingDate.Year, _bookings[bookingId].BookingDate.Month, _bookings[bookingId].BookingDate.Day, returnHour, 0, 0);
                }
                else
                {
                    throw new KeyNotFoundException($"#Error: No bookings with ID: {bookingId}");
                }
            }
            catch(KeyNotFoundException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }


        public List<Booking> GetAll()
        {
            return _bookings.Values.ToList();
        }

        public void PrintAllBookings()
        {
            Console.WriteLine("=====================================================\n\t\tList of all bookings\n=====================================================");
            foreach (Booking booking in _bookings.Values)
            {
                Console.WriteLine(booking.ToString());
            }
            Console.WriteLine("=====================================================");
        }

        #endregion
        #region Methods
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
        public void LeaveDock(int bookingId)
        {
            try
            {
                Booking booking = _bookings[bookingId];
                if (_bookings.ContainsKey(bookingId))
                {
                    booking.AtSea = true;
                }
                else
                {
                    throw new KeyNotFoundException($"#Error: No bookings with ID: {bookingId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ReturnedToDock(int bookingId)
        {
            try
            {
                Booking booking = _bookings[bookingId];
                if (_bookings.ContainsKey(bookingId))
                {
                    booking.AtSea = false;
                }
                else
                {
                    throw new KeyNotFoundException($"#Error: No bookings with ID: {bookingId}");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }

      
        #endregion
    }
}
