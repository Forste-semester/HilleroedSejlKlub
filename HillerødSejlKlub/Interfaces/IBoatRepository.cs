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

        BoatType TheBoatType { get; set; }


        public static void AddBoat(Boat boat)
        {

        }

        public static void AddBoatToRepositoryManually()
        {
           
        }

        public static void GetBoatByID()
        {

        }

        public void RemoveBoatByID(int id);

       public  string UpdateBoatByID();

        public static void PrintAllBoats()
        {

        }



    }
}
