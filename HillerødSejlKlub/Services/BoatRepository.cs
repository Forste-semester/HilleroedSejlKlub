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
        private Dictionary<int, Boat> _boatDictionary;

        public BoatRepository()
        {
            _boatDictionary = new Dictionary<int, Boat>(BoatCollection.boatData);
        }

        public void AddBoat(Boat boat)
        {
            _boatDictionary.Add(boat.Id, boat);
        }

        public Dictionary<int, Boat> GetAllBoats()
        {
            return _boatDictionary;
        }

        public void GetBoatByID(int id)
        {
            if (_boatDictionary.TryGetValue(id, out Boat boat))
            {
                Console.WriteLine(boat);
            }
            else
            {
                Console.WriteLine($"Boat {id} is not found.");
            }
        }

        public void PrintAllBoats()
        {
            foreach (var boat in _boatDictionary.Values)
            {
                Console.WriteLine(boat);
            }
        }

        public void RemoveBoatByID(int id)
        {
            string message = _boatDictionary[id].ToString();
            _boatDictionary.Remove(id);

            BoatMaintenanceLog.Save($"{message} was removed from list.\n");
        }

        public void UpdateBoatByID(int id, string newName, string newModel, BoatType newBoatType, double newSize, bool newMaintenance)
        {
            _boatDictionary.ContainsKey(id);
            Boat boat = _boatDictionary[id];
            boat.Name = newName;
            boat.Model = newModel;
            boat.BoatType = newBoatType;
            boat.Size = newSize;
            boat.Maintenance = newMaintenance;

            string message = $"{boat} got updated info.\n";
            BoatMaintenanceLog.Save(message);
        }
    }
}
    