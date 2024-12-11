using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using HillerødSejlKlub.Data;

namespace HilleroedSejlKlubLibrary.Data
{
    public class MaintenanceCollection
    {
        
        private static List<Maintenance>  _maintenanceData= new List<Maintenance>()
        {

            new Maintenance(Boats(1), "Oil change", 500),
            new Maintenance(Boats(2), "New sails", 5000),
            new Maintenance(Boats(2), "Painted hull", 2000),
            new Maintenance(Boats(4), "New mast", 10000),
            new Maintenance(Boats(5), "Oil change", 500)
        };

        public static List<Maintenance> MaintenanceData {  get { return _maintenanceData; } }
        public static Boat Boats(int boatId)
        {
            if (BoatCollection.boatData.ContainsKey(boatId))
            {
                return BoatCollection.boatData[boatId];
            }
            return null;
        }

    }
}
