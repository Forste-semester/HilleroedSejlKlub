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

        public Blog(string title, string description, DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
            Id = Title;
        }

        public Blog() { }
        #endregion


        #region Properties

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Id { get; set; }

        #endregion Properties


        #region Methods
        public override string ToString()
        {
            return $"title: {Title}, desciption: {Description}, date: {Date}";
        }
        #endregion Methods

    }


}
