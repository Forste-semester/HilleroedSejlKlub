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
        List<Event> GetAllEvents();

        void AddEvent(Event events);
        void JoinEvent(string name);

        Event GetEventByTitle(string title);

        void RemoveEvent(string title);

        void PrintAllEvents();
    }
}
