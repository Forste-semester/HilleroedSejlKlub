using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public static class BookingCollection    
    {
        #region Data
        private static Dictionary<int, Booking> _bookingData = new Dictionary<int, Booking>()
        {
            {1,new Booking(Users(1), Boats(1), DateOnly.Parse("4/12/2024"),11,"hillerød sø") },
            {2,new Booking(Users(1), Boats(1), DateOnly.Parse("6/12/2024"),16,"havet") },
            {3,new Booking(Users(2), Boats(2), DateOnly.Parse("8/12/2024"),14,"hillerød flod") },
            {4,new Booking(Users(3), Boats(3), DateOnly.Parse("12/12/2024"),20,"ishøj strand") },
            {5,new Booking(Users(4), Boats(4), DateOnly.Parse("16/12/2024"),13,"lyngy sø" )},
            {6,new Booking(Users(5), Boats(5), DateOnly.Parse("24/12/2024"),22,"hillerød sø") }
        };
        #endregion
        #region Properties
        public static Dictionary<int, Booking> BookingData
        {
            get { return _bookingData; }
        }
        #endregion
        #region Methods
        public static User Users(int userId)
        {
            if (UserCollection.UserData.ContainsKey(userId))
            {
                return UserCollection.UserData[userId];
            }
            return null;
        }
        public static Boat Boats(int boatId)
        {
            if (BoatCollection.boatData.ContainsKey(boatId))
            {
                return BoatCollection.boatData[boatId];
            }
            return null;
        }
        #endregion
    }
}

