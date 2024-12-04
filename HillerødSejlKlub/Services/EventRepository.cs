using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class EventRepository : IEventRepository
    {
        private Dictionary<string,Event> _events; 
        private List<User> _usersJoined;

        public EventRepository()
        {
            _events = new Dictionary<string, Event>();
        }
        public void AddEvent(Event events)
        {
            
            if (!_events.ContainsKey(events.Title))
            {
                _events.Add(events.Title,events);
                _usersJoined = new List<User>();
            }

            
        }
        public void JoinEvent(string name)
        {
            foreach (var user in _usersJoined) {
                if (user.Name!=name)
                {
                    _usersJoined.Add(user);
                }
            }

            //throw new NotImplementedException();
        }

        public List<Event> GetAllEvents()
        {
            return _events.Values.ToList();
            throw new NotImplementedException();
        }

        public Event GetEventByTitle(string title)
        {
            if (!_events.ContainsKey(title))
            {
                return _events[title];
            }
            throw new NotImplementedException();
        }

        public void PrintAllEvents()
        {
            foreach (var events in _events.Values)
            {
                Console.WriteLine(events.ToString());
                Console.WriteLine();
            }
            if (_events.Count < 1)
            {
                throw new NotImplementedException();
            }
        }

        public void RemoveFromEvent(string name)
        {
            foreach (var user in _usersJoined)
            {
                if (user.Name != null) { }
            }

        public void RemoveEvent(string title)
        {
            if (!_events.ContainsKey(title))
            {
                _events.Remove(title);
            }
            else
            throw new NotImplementedException();
        }

        public void

        public override string ToString()
        {
            if (_events.Count == 0)
            {
                return "Event list is empty.";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Customer Repository Details:");
            sb.AppendLine($"Total Customers: {_events.Count}");

            foreach (var customer in _events.Values)
            {
                sb.AppendLine(customer.ToString());
            }

            return sb.ToString();
        }

        
    }
}
