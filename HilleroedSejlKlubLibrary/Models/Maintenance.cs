using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Data;
using static System.Net.Mime.MediaTypeNames;

namespace HillerødSejlKlub.Models
{
    public class Maintenance : MaintenanceCollection
    {
        private static int _maintenanceId = 1;
        
        public Maintenance(Boat boat, string description, double cost)
        {
            MaintenanceId = _maintenanceId++;
            Description = description;
            Cost = cost;
            Date = DateOnly.FromDateTime(DateTime.Now);
            BoatName = boat.Name;
            boat.AddMaintenance(this);
        }



        public int MaintenanceId { get; }
        public string Description { get; }
        public double Cost { get; }
        public DateOnly Date { get; }
        public string BoatName { get; }

        

        public override string ToString()
        {
            return $"Boat: {BoatName}\nId: {MaintenanceId}\nDescription: {Description}\nCost: {Cost}kr\nDate: {Date}";
        }
    }
}
