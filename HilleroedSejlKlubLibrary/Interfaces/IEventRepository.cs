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
        #region Methods
        void AddEvent(string title, string body, int day, int month, int year, string time, string location, string creator, double price);
        List<Event> GetAllEvents();
        Event GetEventByTitle(string eventTitle);
        void EditEvent(string eventTitle, string newBody, int day, int month, int year, string newTime, string newLocation, string newCreator, double newPrice);
        void RemoveEvent(string eventTitle);
        void JoinEvent(string eventTitle, User user);
        void RemoveFromEvent(string eventTitle, User user);
        void PrintParticipants(string eventTitle);
        void PrintAllEvents();
        #endregion
    }
}
