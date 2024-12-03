using HillerødSejlKlub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Booking
    {
        private static int _nextId;
        private int _id;
        private DateOnly _bookingDay;
        private DateTime _returnTime;
        private bool _atSea;
        private User _user;
        private Boat _boat;

        public Booking(User user, Boat boat, DateOnly bookingDay, int returnHour)
        {
            _nextId++;
            _id = _nextId;
            _user = user;
            _boat = boat;
            _bookingDay = bookingDay;
            _returnTime = new DateTime(_bookingDay.Year, _bookingDay.Month,_bookingDay.Day, returnHour, 0, 0)  ;
            

        }

        public int Id
        {
            get { return _id; }
        }


        public DateOnly BookingDay
        {
            get { return _bookingDay; }
            set { _bookingDay = value; }
        }

        public DateTime ReturnTime
        {
            get { return _returnTime ; }
            set { _returnTime = value ; }
        }

        public bool AtSea
        {
            get
            {
                return _atSea;
            }
            set 
            { 
                _atSea = value;
            }
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
        
        public User User
        {
            get { return _user; }
        }

        public Boat Boat
        {
            get { return _boat; }
        }

        public string Emergency()
        {
            return $"EMERGENCY! ...skal rettes til user.Name... has not returned! Send patrols ASAP!";
        }

        public override string ToString()
        {
            return $"----Booking---- \nID: {_id}\nBooking Day: {_bookingDay}\nReturn Time: {_returnTime}\nAt Sea: {_atSea}\nEmergency Status: {EmergencyStatus}\n{_user.ToString()}\n{_boat.ToString()}";
        }

    }
}
