using HilleroedSejlKlubLibrary.Data;
using HilleroedSejlKlubLibrary.Models;
using HilleroedSejlKlubLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilleroedSejlKlubLibrary.Models
{
    public class DieselEngine : Engine
    {
        #region Constructor
        public DieselEngine(string name, int tankCapacityInLiters, FuelType fuelType) : base(name, fuelType)
        {

            TankCapacity = tankCapacityInLiters;

        }

        #endregion
        
        #region Properties
        public int TankCapacity { get; set; }
        #endregion
        
        #region Methods

        public override string ToString()
        {
            return $"Navn: {Name}\nBrændstof: {FuelType.ToString().Substring(0, 1).ToUpper() + FuelType.ToString().Substring(1).ToLower()}\nTank størrelse: {TankCapacity}";



        }



        #endregion
    }




}
