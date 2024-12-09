using HillerødSejlKlub.Models;
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
        public GasEngine(string name, int tankCapacityInLiters, int cylinders) : base(name)
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
            return $"Gas Engine: {Name}, Tank capacity: {TankCapacity}, Cylinders: {Cylinders}";
        }


        #endregion
    }
}
