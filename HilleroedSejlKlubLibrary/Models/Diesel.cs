using HillerødSejlKlub.Models;
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
        public DieselEngine(string name, int tankCapacityInLiters) : base(name)
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
            return $"Diesel Engine: {Name}, Tank capacity: {TankCapacity}";
        }

     

        #endregion

    }




}
