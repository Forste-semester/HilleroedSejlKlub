using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public class BoatCollection
    {

        private static Dictionary<int, Boat> _boatData = new Dictionary<int, Boat>();





        public static Dictionary<int, Boat> PrintAllBoats()
        {
            return _boatData;
        }

        public static Dictionary<int, Boat> boatData { get { return _boatData; } }


    }
}
