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
        int Id { get; }
        DateOnly BookingDate {  get; set; }
        DateTime ReturnTime { get; set; }
        bool AtSea {  get; set; }
        string EmergencyStatus { get; }
        User User { get; }
        Boat Boat { get; }
        string Location { get; set; }
        #endregion
        #region Methods
        string Emergency();
        string ToString();
        #endregion
    }
}
