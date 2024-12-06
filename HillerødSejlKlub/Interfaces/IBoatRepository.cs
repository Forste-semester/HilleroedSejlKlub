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
        void GetBoatByID(int id);
        void RemoveBoatByID(int id);
        void UpdateBoatByID(int id, string name, string model, BoatType boatType, double size, bool maintenance);
        void PrintAllBoats();
    }
}
