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

        public Event(string title, string body, string date, string time, string location, string creator, double price)
        {
            Title = title;
            Body = body;
            Date = date;
            Time = time;
            Location = location;
            Creator = creator;
            Price = price;

        }

        public string Title { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Location { get; set; }
        public string Creator { get; set; }
        public double Price { get; set; }
        public List<User> Participants { get; set; } 



        public override string ToString()
        {
            return $"Event: {Title}\nDate: {Date}\nTime: {Time}\nWhere: {Location}\nPrice: {Price}kr\nCreated by: {Creator}\n";
        }

    }
}
