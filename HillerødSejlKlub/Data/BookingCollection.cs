﻿using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public class BookingCollection    
    {
        #region Data
        private static Dictionary<int, Booking> _bookingData = new Dictionary<int, Booking>()
        {
            {1,new Booking(Users(1), Boats(1), DateOnly.Parse("4/12/2024"),4) },
            {2,new Booking(Users(1), Boats(1), DateOnly.Parse("4/12/2024"),8) },
            {3,new Booking(Users(2), Boats(2), DateOnly.Parse("8/12/2024"),12) },
            {4,new Booking(Users(3), Boats(3), DateOnly.Parse("12/12/2024"),16) },
            {5,new Booking(Users(4), Boats(4), DateOnly.Parse("16/12/2024"),20) },
            {6,new Booking(Users(5), Boats(5), DateOnly.Parse("24/12/2024"),20) }

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
            else 
            {
                throw new Exception($"No users found with ID{userId}");
            }
        }
        public static Boat Boats(int boatId)
        {
            if (BoatCollection.boatData.ContainsKey(boatId))
            {
                return BoatCollection.boatData[boatId];
            }
            else
            {
                throw new Exception($"No boats found with ID{boatId}");
            }
        }
        #endregion
    }
}

