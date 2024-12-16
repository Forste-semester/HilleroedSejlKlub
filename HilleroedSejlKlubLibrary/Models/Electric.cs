using HillerødSejlKlub.Models;
using HilleroedSejlKlubLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HilleroedSejlKlubLibrary.Models
{
    public class ElectricEngine : Engine
    {

        #region Constructor

        public ElectricEngine(string name, int batteryCapacityInKWH, FuelType fuelType) : base(name, fuelType)
        {

            BatteryCapacity = batteryCapacityInKWH;
        }
        #endregion
        
        #region Properties
        public int BatteryCapacity { get; set; } // Specific to Electric engines
        #endregion
        
        #region Methods
        public override string ToString()
        {
            return $"Navn: {Name}\nBrændstof: {FuelType.ToString().Substring(0, 1).ToUpper() + FuelType.ToString().Substring(1).ToLower()}\nBatterikapacitet: {BatteryCapacity}";
        }
        #endregion
    }
}
