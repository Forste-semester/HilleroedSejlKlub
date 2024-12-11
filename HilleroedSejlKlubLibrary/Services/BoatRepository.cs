using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
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


        private Dictionary<int, Boat> _boatDictionary = new Dictionary<int, Boat>();


        #endregion


        #region Constructor

        public BoatRepository()
        {
            _boatDictionary = new Dictionary<int, Boat>(BoatCollection.boatData); // Her henter vi fra BoatCollection for at lave repository dictionary
        }
        #endregion


        #region Properties 




        #endregion


        #region Methods

        public void AddBoat(Boat boat)
        {
            if (!_boatDictionary.ContainsKey(boat.Id))
            {


                _boatDictionary.Add(boat.Id, boat);
                Console.WriteLine($"Boat with ID {boat.Id} has been added.");
            }
            else
            {
                throw new KeyNotFoundException($"A boat with ID {boat.Id} already exists.");

            }
        }

        public Dictionary<int, Boat> GetAll()
        {
            if (!_boatDictionary.Any())
            {
                throw new ArgumentException("There are no Boats.");
            }
            return _boatDictionary;
        }


        public void PrintAllBoats()  // void
        {
            foreach (Boat boats in _boatDictionary.Values)
            {
                Console.WriteLine(boats.ToString());
                Console.WriteLine();
            }

        }


        public void PrintBoats()
        {
            if (!_boatDictionary.Any())
            {
                throw new InvalidOperationException("There are no Boats to print.");
            }
            foreach (var boat in _boatDictionary.Values)
            {

                Console.WriteLine(boat.ToString());

            }
        }

        public Boat GetBoatByID(int id)
        {

            if (_boatDictionary.ContainsKey(id))
            {

                return _boatDictionary[id];


            }
            else
            {
                throw new KeyNotFoundException($"No boat found with ID {id}");

            }



        }


        public void RemoveBoatByID(int id)
        {

            if (_boatDictionary.ContainsKey(id))
            {

                _boatDictionary.Remove(id);
                Console.WriteLine($"Boat with ID {id} has been removed.");
            }
            else
            {
                throw new KeyNotFoundException($"No boat found with ID {id}");

            }
        }


        public void UpdateBoatByID(int id, string newName, string newModel, BoatType newBoatType, double newSize)

        {
            _boatDictionary.ContainsKey(id);
            Boat boat = _boatDictionary[id];
            boat.Name = newName;
            boat.Model = newModel;
            boat.BoatType = newBoatType;
            boat.Size = newSize;


            string message = $"{boat} got updated info.\n";
            BoatMaintenanceLog.Save(message);
        }


        public void AddMaintenanceToBoat(int boatId, Maintenance maintenance)
        {
            Boat boat = GetBoatByID(boatId);

            if (boat != null)
            {
                boat.AddMaintenance(maintenance);
                Console.WriteLine($"Maintenance added to boat with ID {boatId}.");
            }
            else
            {
                Console.WriteLine($"Boat with ID {boatId} not found.");
            }
        }
        #endregion

    }

}



