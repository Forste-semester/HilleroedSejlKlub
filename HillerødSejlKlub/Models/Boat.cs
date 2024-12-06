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


    

        public Boat(string name, string model, BoatType boatType, int licenseplate, double size, int year)

        

        {
            Id = _nextId++;
            Name = name;
            Model = model;
            BoatType = boatType;
            Id = _nextId++;
            LicensePlate = licenseplate;
            Size = size;
            Year = year;
            

        }

        #endregion

        #region Properties

        public int Id { get; }
        public string Name { get; set; }
        public string Model { get; set; }
        public BoatType BoatType { get; set; }
        public double Size { get; set; }
        public int Year { get; set; }

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
            return $"Name: {Name}\nModel: {Model}\nType: {Type}\nId: {LicensePlate}\nSize: {Size} ft\nYear: {Year}\n";


        }
    }
}
