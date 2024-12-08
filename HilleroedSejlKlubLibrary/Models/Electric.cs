using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilleroedSejlKlubLibrary.Models
{
    public class ElectricEngine : Engine
    {
        public int BatteryCapacity { get; set; } // Specific to Electric engines

        public ElectricEngine(string name, int batteryCapacityInKWH) : base(name)
        {
            BatteryCapacity = batteryCapacityInKWH;
        }

        public override string ToString()
        {
            return $"Electric Engine: {Name}, Tank capacity: {BatteryCapacity}";
        }

      
    }
}
