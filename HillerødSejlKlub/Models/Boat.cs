using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
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
        public static int _nextId = 1;

        public Boat(string name, string model, BoatType boatType, double size, int year, bool maintenance)
        {
            Id = _nextId++;
            Name = name;
            Model = model;
            BoatType = boatType;
            Size = size;
            Year = year;
            Maintenance = maintenance;
        }

        public int Id { get; }
        public string Name { get; set; }
        public string Model { get; set; }
        public BoatType BoatType { get; set; }
        public double Size { get; set; }
        public int Year { get; set; }
        public bool Maintenance { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {Name}\nModel: {Model}\nType: {BoatType}\nSize: {Size} ft\nYear: {Year}\nMaintenance Needed: {(Maintenance ? "Yes" : "No")}\n";
        }
    }
}
