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
            {1, new Boat("Hammer", "Yamaha X-100", BoatType.SEJLBAAD, 1514, 35, 2020, false) },
            {2, new Boat("Emilie", "Mustang X-500", BoatType.MOTORBAAD, 1322, 33, 2020, false) },
            {3, new Boat("Ole", "Wavebreaker 3000", BoatType.KAJAK, 1013, 15, 2023, false) },
            {4, new Boat("Frederikke", "Wavebreaker 5300", BoatType.ROBAAD, 4934, 13, 2023, false) },
            {5, new Boat("Thor", "Model Yamaha X-100", BoatType.KANO, 9534, 12, 2020, false) }
        };


      

        public static Dictionary<int, Boat> boatData { get { return _boatData; } }

       
    
    }
}
