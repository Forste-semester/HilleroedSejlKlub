using HillerødSejlKlub.Data;
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
        string Name { get; }
        string Model { get; }
        BoatType BoatType { get; }
        double Size { get; }
        int Year { get; }
        bool Maintenance { get; }
        string ToString();

    }
}
