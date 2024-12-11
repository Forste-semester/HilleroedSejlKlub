using HilleroedSejlKlubLibrary.Data;
using HilleroedSejlKlubLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HillerødSejlKlub.Models
{
    public abstract class Engine : IEngine
    {
        #region Constructor
        protected Engine(string name, FuelType fuelType)
        {
            Name = name;
            FuelType = fuelType;
        }
        #endregion
        #region Properties
        public string Name { get; private set; }
        public FuelType FuelType { get; set; }
        public string FormattedFuelType
        {
            get
            {
                if (FuelType == null)
                {
                    return string.Empty;
                }
                    else
                {
                    string fuelTypeString = FuelType.ToString(); 
                    return char.ToUpper(fuelTypeString[0]) + fuelTypeString.Substring(1).ToLower(); 
                }

              
            }
        }
        #endregion
        #region Methods



        public abstract string ToString();


        #endregion

    }
}
