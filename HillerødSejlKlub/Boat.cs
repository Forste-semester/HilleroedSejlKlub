using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HillerødSejlKlub
{
    public class Boat
    {

        #region Instance fields
        private Dictionary<int, Boat> _boats = new Dictionary<int, Boat>();

        #endregion

        #region Constructors 
        public Boat(string name, string model, string type, int id, double size, int year, bool maintenance)
        {
            Name = name; 
            Model = model; 
            Type = type; 
            Id = id; 
            Size = size; 
            Maintenance = maintenance;


        }
        #endregion

        #region Properties

        private string Name { get; set; }

        private string Model { get; set; }

        private string Type { get; set; }

        private int Id { get; set; }

        private double Size { get; set; }

        private int Year { get; set; }

        private bool Maintenance { get; set; }

        #endregion


    }
}
