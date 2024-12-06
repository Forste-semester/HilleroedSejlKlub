using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Blog : BlogRepository, IBlogRepository
    {
        private string _title;
        private string _description;
        private DateTime _date;


        #region Constructor 

        public Blog(string title, string description, DateTime date)
        {
            Title = title;
            Description = description;
            Date = date;
        }
        #endregion


        #region Properties

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        #endregion Properties


        #region Methods
        public override string ToString()
        {
            return $"title: {Title}, desciption: {Description}, date: {Date}";
        }
        #endregion Methods

    }


}
