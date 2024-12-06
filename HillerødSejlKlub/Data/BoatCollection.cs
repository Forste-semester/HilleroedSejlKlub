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
        private static Dictionary<int, Boat> _boatData = new Dictionary<int, Boat>()
        {
            {1, new Boat("S.S. Ann", "model1", BoatType.Motorbåd, 10, 2010, false) },
            {2, new Boat("The Rig", "model2", BoatType.Wayfarer, 7, 2008, true) },
            {3, new Boat("The Dirk", "model3", BoatType.Laserjolle, 11, 2019, false) }
        };

        public static Dictionary<int, Boat> boatData
        {
            get { return _boatData; }
        }


    }
}
