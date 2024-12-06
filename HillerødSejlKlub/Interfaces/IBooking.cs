using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    public interface IBooking
    {
        #region Properties
        public int Id { get; }
        public DateOnly BookingDate {  get; set; }
        public DateTime ReturnTime { get; set; }
        public bool AtSea {  get; set; }
        public string EmergencyStatus { get; }
        public User User { get; }
        public Boat Boat { get; }
        #endregion
        #region Methods
        public string Emergency();
        public string ToString();
        #endregion
    }
}
