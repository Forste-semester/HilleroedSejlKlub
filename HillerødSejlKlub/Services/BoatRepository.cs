using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class BoatRepository : IBoatRepository
    {
        #region Instance fields


        private static Dictionary<int, Boat> _boatDictionary = new Dictionary<int, Boat>();

        private static List<Boat> boatsAtSeaList = new List<Boat>();

        public BoatType TheBoatType { get; set; }



        #endregion





        #region Constructor

        public BoatRepository()
        {

         _boatDictionary = new Dictionary<int, Boat>(BoatCollection._boatData); // Her henter vi fra BoatCollection for at lave repository dictionary

        }





        #endregion



        #region Properties 





        #endregion



        #region Methods

        public  void AddBoat(Boat boat)
        {
            if (!_boatDictionary.ContainsKey(boat._id))
            {
                _boatDictionary.Add(boat._id, boat);
            }
            else
            {
                Console.WriteLine($"A boat with ID {boat._id} already exists.");
            }
        }

        public static Dictionary<int, Boat> PrintAllBoats() 
        {
            return _boatDictionary;
        }

        public static Boat GetBoatByID(int id)
        {
            foreach (var kvp in _boatDictionary) // Kvp (KeyValuePair) har metoder hvorpå man kan get Key eller Value, f.eks. .Key, .Value
            {
                if (kvp.Key == id)
                {

                    return kvp.Value;


                }
            }
            return null;

        }


        /* Nødvendig? Giver det mening at oprette både en dictionary og list pr automatik?
        public List<Boat> GetAllBoatsList()
        {
            return boatDictionary.Values.ToList(); // Konverter til List med values
        }
        */

        public void RemoveBoatByID(int id)
        {
          
            if (_boatDictionary.ContainsKey(id))
            {
              
                _boatDictionary.Remove(id);
                Console.WriteLine($"Boat with ID {id} has been removed.");
            }
            else
            {
               
                Console.WriteLine($"No boat found with ID {id}");
            }
        }
        public string UpdateBoatByID() // Hjælp, hvordan skal det gøres? Via en constructor metode som modtager direkte nye detaljer?
        {
            throw new NotImplementedException();
        }

        public void ListOfBoatsAtSea() // Kan man lave en metode hvorpå at list of sea boats bliver opdateret når dateTime.Start og End i bookingen er dags dato, for at lave noget automatisering?
        {

        }


        /*

              public Boat GetBoatByID(int id)
              {
                  foreach (Boat boat in boatList)
                  {
                      if (boat.Id == id)
                      {

                          return boat;


                      }
                  }
                  return null;

              }





              public string RemoveBoatByID(int id)
              {

                  foreach (Boat boat in boatList)
                  {
                      if (boat.Id == id)
                      {
                          boatList.Remove(boat);  

                          return $"{boat} has succesfully been removed";


                      }


                  }
                  return $"No boat found with ID: {id}.";

              }

              public string UpdateBoatByID(string name, string model, string type, int id, double size, int year, bool maintenance)
              {


                  foreach (Boat boat in boatList)
                  {
                      if (boat.Name == id)
                      {
                          // Update the boat's details
                          boat.Name = name;
                          boat.Model = model;
                          boat.Type = type;
                          boat.Size = size;
                          boat.Year = year;
                          boat.Maintenance = maintenance;

                          // Return a success message
                          return $"Boat with ID {id} has been successfully updated.";
                      }
                  }

                  // If no boat is found with the given ID
                  return $"No boat found with ID: {id}.";

              }

          


                  */


        #endregion
    }
}
    