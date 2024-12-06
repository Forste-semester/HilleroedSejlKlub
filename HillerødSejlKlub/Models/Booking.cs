using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Booking : IBooking
    {
        #region Instance fields
        private static int _nextId;
        private int _id;
        private DateOnly _bookingDate;
        private DateTime _returnTime;
        private bool _atSea;
        #endregion
        #region Constructor
        public Booking(User user, Boat boat, DateOnly bookingDate, int returnHour)
        {
            _nextId++;
            _id = _nextId;
            User = user;
            Boat = boat;
            _bookingDate = bookingDate;
            _atSea = false;
            _returnTime = new DateTime(_bookingDate.Year, _bookingDate.Month,_bookingDate.Day, returnHour, 0, 0)  ;
        }
        #endregion
        #region Properties
        public int Id
        {get { return _id; }}

        public DateOnly BookingDate
        {
            get {return _bookingDate; }
            set { _bookingDate = value; }
        }

        public DateTime ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
        }

        public bool AtSea
        {
            get { return _atSea; }
            set { _atSea = value; }
        }

        public string EmergencyStatus
        {
            get
            {
                if (_atSea == true && DateTime.Now > _returnTime)
                {
                    return Emergency();
                }
                else
                {
                    return "No emergency at this moment!";
                }
            }
        }
        
        public User User { get;}

        public Boat Boat{ get;}
        #endregion
        #region Methods
        public string Emergency()
        {
            return $"EMERGENCY! {User.Name} has not returned within his/her estimated return time period! Send patrols ASAP!";
        }

        public override string ToString()
        {
            return $"----------------------------------------\n\tBooking Receipt (#{Id})\n----------------------------------------\n\nBooking Day: {BookingDate}\nReturn to dock time: {ReturnTime}\nEmergency Status: {EmergencyStatus}\nAt Sea: {_atSea}\n\n----------------------------------------\nPersonal Information\n----------------------------------------\n{User.ToString()}\n\n----------------------------------------\nBoat Information\n----------------------------------------\n{Boat.ToString()}\n\n----------------------------------------\n";
        }
        #endregion
    }
}
