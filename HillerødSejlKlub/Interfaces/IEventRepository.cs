using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HillerødSejlKlub.Models;

namespace HillerødSejlKlub.Interfaces
{
    public interface IEventRepository
    {
        

        void AddEvent(Event events);
        Dictionary<string, Event> GetAllEvents();
        Event GetEventByTitle(string eventTitle);
        void EditEvent(Event events, string newBody, string newDate, string newTime, string newLocation, string newCreator, double newPrice);
        void RemoveEvent(string eventTitle);
        void JoinEvent(string eventTitle, User user);
        void RemoveFromEvent(string eventTitle, User user);
        void PrintParticipants(string eventTitle);
        void PrintAllEvents();
    }
}
