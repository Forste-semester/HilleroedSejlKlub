using HillerødSejlKlub.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class Event : IEvent
    {
        #region Constructor
        public Event(string title, string body, int day,int month,int year, string time, string location, string creator, double price)
        {
            Title = title;
            Body = body;
            Day = day;
            Month = month; 
            Year = year;
            Time = time;
            Location = location;
            Creator = creator;
            Price = price;
            Participants = new List<User>();
        }
        #endregion
        #region Properties
        public Event() { Participants = new List<User>(); }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Creator { get; set; }
        public double Price { get; set; }
        public List<User> Participants { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {
            if(Price == 0)
            {
                string newPrice = "Free";
                return $"Event: {Title}\nDate: {Day + Month + Year}\nTime: {Time}\nWhere: {Location}\nPrice: {newPrice}kr\nCreated by: {Creator}\n";
            }
            return $"Event: {Title}\nDate: {Day + Month + Year}\nTime: {Time}\nWhere: {Location}\nPrice: {Price}kr\nCreated by: {Creator}\n";
        }
        #endregion
    }
}
