using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    public interface IEvent
    {
        #region Properties
        string Title { get; set;  }
        string Body { get; set; }
        int Day { get; set; }
        int Month { get; set; }
        int Year { get; set; }
        string Time { get; set; }
        string Location { get; set; }
        public string Creator { get; set; }
        public double Price { get; set; }
        #endregion
        #region Methods
        string ToString();
        #endregion
    }
}
