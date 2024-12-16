using HillerødSejlKlub.Models;
using HilleroedSejlKlubLibrary;
using HilleroedSejlKlubLibrary.Data;
using HilleroedSejlKlubLibrary.Models;
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
            {1, new Boat("Hammer", "Yamaha X-100", BoatType.Sejlbåd, 15, 2020, "DY2461", "/images/sejlbaad.jpg" , new GasEngine("Mercruiser", 20, 8, FuelType.Benzin)) },
            {2, new Boat("Emilie", "Mustang X-500", BoatType.Europajolle, 3.4, 2020,"YZ2682", "/images/europajolle.jpg") },
            {3, new Boat("Ole", "Wavebreaker 3000", BoatType.Optimistjolle, 2.8, 2023, "OD5127", "/images/optimistjolle.jpg" , new ElectricEngine("Ultra Minn Kota Endura", 34, FuelType.El)) },
            {4, new Boat("Frederikke", "Wavebreaker 5300", BoatType.Motorbåd, 4.9, 2023, "OP2841", "/images/motorbaad.jpg" , new DieselEngine("Bladt Diesel X-300", 30, FuelType.Diesel)) },
            {5, new Boat("Thor", "Yamaha X-100", BoatType.Snipejolle, 4.1, 2020, "BY1627") }
        };

        public static Dictionary<int, Boat> boatData { get { return _boatData; } }
    }

}

