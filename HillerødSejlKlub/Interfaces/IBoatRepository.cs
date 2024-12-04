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

        


         void AddBoat(Boat boat)
        {}

        

         void GetBoatByID()
        {}

        void RemoveBoatByID(int id);

        string UpdateBoatByID();

        void PrintAllBoats()
        {}

    }
}
