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
        private string _title;
        private string _body;
        private string _date;
        private string _time;
        private string _where;
        private string _creator; //Creator would be a person object.

        public Event(string title, string body, string date, string time, string where, string creator) //Creator would probably not be part of the requirements for the constructor.
        {
            Title = title;
            Body = body;
            Date = date;
            Time = time;
            Where = where;
            Creator = creator;
           

        }

        public string Title { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Where { get; set; }
        public string Creator { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
