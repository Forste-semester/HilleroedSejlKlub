using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IBoatRepository
    {

        Dictionary<int, Boat> GetAllBoats();
        void AddBoat(Boat boat);
        Boat GetBoatByID(int id);
        void RemoveBoatByID(int id);
        void UpdateBoatByID(int id, string newName, string newModel, BoatType newBoatType, double newSize);
        void PrintAllBoats();

    }
}
