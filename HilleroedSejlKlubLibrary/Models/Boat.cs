using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
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


    

        public Boat(string name, string model, BoatType boatType, double size, int year, string sailNumber)

        {
            Id = _nextId++;
            Name = name;
            Model = model;
            BoatType = boatType;
            Size = size;
            Year = year;
            SailNumber = sailNumber;
            List<Maintenance> Boatlog = new List<Maintenance>();

        }

        public Boat(string name, string model, BoatType boatType, double size, int year, string sailNumber, Engine engine) : this(name, model, boatType, size, year, sailNumber)

        {
            Engine = engine;

        }

        #endregion

        #region Properties

        public int Id { get; }
        public string SailNumber { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public BoatType BoatType { get; set; }
        public double Size { get; set; }
        public int Year { get; }

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
                engineDetails = "No engine installed.";
            }
            return $"Name: {Name}\nModel: {Model}\nType: {BoatType}\nId: {Id}\nSize: {Size} ft\nYear: {Year}\nEngine: {engineDetails}";


        }

      

        #endregion
    }
}
