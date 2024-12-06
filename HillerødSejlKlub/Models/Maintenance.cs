using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Maintenance
    {
        private static int _maintenanceId = 1;
        public Maintenance(string description, double cost, DateOnly date)
        {
            MaintenanceId = _maintenanceId++;
            Description = description;
            Cost = cost;
            Date = date;
        }
        public int MaintenanceId { get; }
        public string Description { get; }
        public double Cost { get; }
        public DateOnly Date { get; }

        public override string ToString()
        {
            return $"Id: {MaintenanceId}\nDescription: {Description}\nCost: {Cost}kr\nDate: {Date}";
        }
    }
}
