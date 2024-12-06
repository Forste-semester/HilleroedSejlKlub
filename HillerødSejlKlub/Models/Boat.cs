using HillerødSejlKlub.Data;
using HillerødSejlKlub.Services;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HillerødSejlKlub.Models
{
    public class Boat
    {

        #region Instance fields

        public static int _nextId = 1;

        #endregion

        #region Constructors 

        public Boat(string name, string model, BoatType boatType, int licenseplate, double size, int year, bool maintenance)
        
        {
            
            Name = name;
            BoatType = boatType;
            Model = model;
            Id = _nextId++;
            LicensePlate = licenseplate;
            Year = year;
            Size = size;
            Maintenance = maintenance;

        }
        #endregion

        #region Properties

        public BoatType BoatType { get; set; }

        public int Id { get; }

        public string Name { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public int LicensePlate { get; set; }

        public double Size { get; set; }

        public int Year { get; set; }

        public bool Maintenance { get; set; }


        #endregion



        #region Methods


        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nModel: {Model}\nType: {Type}\nId: {LicensePlate}\nSize: {Size} ft\nYear: {Year}\nMaintenance: {(Maintenance ? "Yes" : "No")}";
        }

        #endregion


    }
}
