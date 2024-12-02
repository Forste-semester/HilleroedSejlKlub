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
        private Dictionary<int, Boat> _boats = new Dictionary<int, Boat>();
        private int _id;

        private static int _nextId = 1;

        #endregion

        #region Constructors 
        public Boat(string name, string model, string type, int id, double size, int year, bool maintenance)
        {
            Name = name;
            Type = type;
            Model = model;
            _id = _nextId++;
            Id = id;
            Size = size;
            Maintenance = maintenance;


        }
        #endregion

        #region Properties

        public string Name { get; set; }

        public string Model { get; set; }

        public string Type { get; set; }

        public int Id { get; set; }

        public double Size { get; set; }

        public int Year { get; set; }

        public bool Maintenance { get; set; }





        #endregion


    }
}
