using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public static class BoatCollection
    {
        
        private static Dictionary<int, Boat> _boatData = new Dictionary<int, Boat>()
        {
            {1, new Boat("Hammer", "Yamaha X-100", BoatType.Sejlbåd, 35, 2020, "DY2461") },
            {2, new Boat("Emilie", "Mustang X-500", BoatType.Europajolle, 33, 2020,"YZ2682") },
            {3, new Boat("Ole", "Wavebreaker 3000", BoatType.Optimistjolle, 15, 2023, "OD5127") },
            {4, new Boat("Frederikke", "Wavebreaker 5300", BoatType.Motorbåd, 13, 2023, "OP2841") },
            {5, new Boat("Thor", "Yamaha X-100", BoatType.Snipejolle, 12, 2020, "BY1627") }
        };

        public static Dictionary<int, Boat> boatData { get { return _boatData; } }

       
       }

}

