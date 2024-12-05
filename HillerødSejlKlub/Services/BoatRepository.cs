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

        public  Dictionary<int, Boat> PrintAllBoats() 
        {
            foreach (Boat boats in _boatDictionary.Values)
            {
                Console.WriteLine(boats.ToString());
                Console.WriteLine();
            }
            return _boatDictionary;
        }

        public  Boat GetBoatByID(int id)
        {
            
            if (_boatDictionary.ContainsKey(id))
            {
                var boat = _boatDictionary[id]; 

                return boat;
                 

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


        public string UpdateBoatByID(int id, string name, string model, BoatType boattype, int licensePlate, double size, int year, bool maintenance)
        {



            if (_boatDictionary.ContainsKey(id))
            {

                var boat = _boatDictionary[id];

                string oldName = boat.Name;
                string oldModel = boat.Model;
                string oldType = boat.Type;
                int oldLicensePlate = boat.LicensePlate;
                double oldSize = boat.Size;
                int oldYear = boat.Year;
                bool oldMaintenance = boat.Maintenance;

                boat.Name = name;
                boat.Model = model;
                boat.Type = boattype.ToString();
                boat.LicensePlate = licensePlate;
                boat.Size = size;
                boat.Year = year;
                boat.Maintenance = maintenance;

                string updateMessage = $"Boat with ID {id} has been successfully updated with the following details:" +
                            $"\nName: {oldName} -> {boat.Name}" +
                            $"\nModel: {oldModel} -> {boat.Model}" +
                            $"\nType: {oldType} -> {boat.Type}" +
                            $"\nLicense Plate: {oldLicensePlate} -> {boat.LicensePlate}" +
                            $"\nSize: {oldSize} -> {boat.Size}" +
                            $"\nYear: {oldYear} -> {boat.Year}" +
                            $"\nMaintenance: {(oldMaintenance ? "Yes" : "No")} -> {(boat.Maintenance ? "Yes" : "No")}\n";

                return boat + updateMessage;
            }


            throw new KeyNotFoundException($"No boat found with ID {id}");
        }

       


        #endregion
    }
}
    