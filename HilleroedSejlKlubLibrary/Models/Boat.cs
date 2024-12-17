using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Models;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
namespace HillerødSejlKlub.Models
{
    public class Boat : IBoat
    {
        #region Instance fields

        public static int _nextId = 1;

        #endregion
        
        #region Constructors 

       
        public Boat()
        {
            Id = _nextId++;
            Boatlog = new List<Maintenance>();
            ImagePath = "/images/billede-paa-vej.jpg"; // Provide a default value
        }

        public Boat(string name, string model, BoatType boatType, double size, int year, string sailNumber, string imagePath = "/images/billede-paa-vej.jpg", Engine engine = null)

        {
            Id = _nextId++;
            Name = name;
            Model = model;
            BoatType = boatType;
            Size = size;
            Year = year;
            SailNumber = sailNumber;
            ImagePath = imagePath;
            Engine = engine;
            Boatlog = new List<Maintenance>();

        }
        
        #endregion
        #region Properties


        public string ImagePath { get; set; }
        public int Id { get; }
        public string SailNumber { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public BoatType BoatType { get; set; }
        public double Size { get; set; }
        public int Year { get; set; }

        public Engine Engine { get; set; }

        public List<Maintenance> Boatlog { get; set; }

        #endregion
        #region Methods
        public void AddMaintenance(Maintenance maintenance)
        {

            Boatlog.Add(maintenance);
        }

        public void PrintBoatLog()
        {
            if (Boatlog.Count == 0)
            {
                Console.WriteLine("No maintenance records found for this boat.");
            }
            else
            {
                Console.WriteLine($"Maintenance log for boat: {Name}");
                Console.WriteLine($"Number of entries: {Boatlog.Count}\n");
                foreach (var maintenance in Boatlog)
                {
                    Console.WriteLine($"Description: {maintenance.Description}\nCost: {maintenance.Cost}kr\nDate: {maintenance.Date}\n");
                }
                Console.WriteLine("End of Log.\n");
            }
        }

        public override string ToString()
        {

            string engineDetails;
            if (Engine != null)
            {
                engineDetails = Engine.ToString();
            }
            else
            {
                engineDetails = "Ingen motor monteret";
            }
            return $"Name: {Name}\nModel: {Model}\nType: {BoatType}\nId: {Id}\nSize: {Size} ft\nYear: {Year}\nEngine: {engineDetails}";


        }



        #endregion
    }
}
