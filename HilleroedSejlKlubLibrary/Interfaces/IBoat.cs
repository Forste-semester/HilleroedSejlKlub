using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HillerødSejlKlub.Interfaces
{
    public interface IBoat
    {

        int Id { get; }
        string SailNumber { get; set; }
        string Name { get; set; }
        string Model { get; }
        BoatType BoatType { get; }
        public Engine Engine { get; set; }

        double Size { get; }
        int Year { get; }
        string ToString();

    }
}
