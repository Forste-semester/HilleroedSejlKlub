using HillerødSejlKlub.Models;
using HilleroedSejlKlubLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HilleroedSejlKlubLibrary.Models
{
    public class GasEngine : Engine
    {
  
        
        #region Constructor
        public GasEngine(string name, int tankCapacityInLiters, int cylinders, FuelType fuelType) : base(name, fuelType)
        {

        
            TankCapacity = tankCapacityInLiters;
            Cylinders = cylinders;

        }

      

        #endregion

        #region Properties
        public int TankCapacity { get; set; }

        
        public int Cylinders { get; set; }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Navn: {Name}\nBrændstof: {FuelType.ToString().Substring(0, 1).ToUpper() + FuelType.ToString().Substring(1).ToLower()}\nTank størrelse: {TankCapacity}\nCylindere: {Cylinders}";
        }


        #endregion
    }
}
