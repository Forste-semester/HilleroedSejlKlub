using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Blog : IBlog
    {

        #region Constructor 

        public Blog(string id, string description, DateTime date)
        {
            Id = id;
            Description = description;
            Date = date;
        }
        #endregion


        #region Properties

        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        #endregion Properties


        #region Methods
        public override string ToString()
        {
            return $"id: {Id}, desciption: {Description}, date: {Date}";
        }
        #endregion Methods

    }


}
