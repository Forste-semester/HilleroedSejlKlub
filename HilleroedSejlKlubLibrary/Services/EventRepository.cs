using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HillerødSejlKlub.Services
{
    public class EventRepository : IEventRepository
    {
        private Dictionary<string, Event> _events;        

        public EventRepository()
        {
            _events = new Dictionary<string, Event>(EventCollection.EventData);
        }
        public void AddEvent(Event eventToAdd)
        {
            if (_events.ContainsKey(eventToAdd.Title))
            {
                throw new ArgumentException($"An event with the title '{eventToAdd.Title}' already exists.");
            }

            _events.Add(eventToAdd.Title, eventToAdd);

        }
        public List<Event> GetAllEvents()
        {
            if (!_events.Any())
            {
                throw new ArgumentException("There are no events.");
            }
            return _events.Values.ToList();
        }

        public Event GetEventByTitle(string eventTitle)
        {
            if (!_events.ContainsKey(eventTitle)) 
            {
                throw new ArgumentException("Event not found.");
            }

            return _events[eventTitle]; 

        }

        public void EditEvent(string title, string newBody, string newDate, string newTime, string newLocation, string newCreator, double newPrice)
        {
            if (string.IsNullOrEmpty(newBody))
            {
                throw new ArgumentException("Body cannot be empty.");
            }
            if (string.IsNullOrEmpty(newDate))
            {
                throw new ArgumentException("Date cannot be empty.");
            }
            if (string.IsNullOrEmpty(newTime))
            {
                throw new ArgumentException("Time cannot be empty.");
            }
            if (string.IsNullOrEmpty(newLocation))
            {
                throw new ArgumentException("Location cannot be empty.");
            }
            if (string.IsNullOrEmpty(newCreator))
            {
                throw new ArgumentException("Creator cannot be empty.");
            }
            if (newPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }

            _events[title].Body= newBody;
            _events[title].Date = newDate;
            _events[title].Time = newTime;
            _events[title].Location = newLocation;
            _events[title].Creator = newCreator;
            _events[title].Price = newPrice;
        }

        public void RemoveEvent(string eventTitle)
        {
            if (!_events.ContainsKey(eventTitle))
            {
                throw new ArgumentException("Event not found.");
            }

            _events.Remove(eventTitle);
        }

        
        
        public void JoinEvent(string eventTitle, User user)
        {
            if (!_events.ContainsKey(eventTitle))
            {
                throw new ArgumentException("Event not found.");
            }

            var eventToJoin = _events[eventTitle];

            if (eventToJoin.Participants == null)
            {
                eventToJoin.Participants = new List<User>(); 
            }

            
            if (eventToJoin.Participants.Any(u => u.Id == user.Id))
            {
                throw new ArgumentException("User has already joined the event.");
            }

            
            eventToJoin.Participants.Add(user);
        }

        public void RemoveFromEvent(string eventTitle, User user)
        {
            if (!_events.ContainsKey(eventTitle))
            {
                throw new ArgumentException("Event not found.");
            }


            var eventToRemoveFrom = _events[eventTitle];


            var userToRemove = eventToRemoveFrom.Participants.FirstOrDefault(u => u.Id == user.Id);

            if (userToRemove != null)
            {
                eventToRemoveFrom.Participants.Remove(userToRemove);
            }
            else
            {
                throw new ArgumentException("User not found in the event.");
            }

        }
        public void PrintParticipants(string eventTitle)
        {
            if (!_events.ContainsKey(eventTitle))
            {
                throw new ArgumentException("Event not found.");
            }

            var eventToShow = _events[eventTitle];
            if (eventToShow.Participants == null)
            {
                Console.WriteLine("No members are attending this event.");
            }
            else
            {
                Console.WriteLine($"Members attending {eventTitle}");
                foreach (var user in eventToShow.Participants)
                {
                    Console.WriteLine(user.Id);
                }
                Console.WriteLine();
            }

        }
        public void PrintAllEvents()
        {
            if (!_events.Any())
            {
                throw new InvalidOperationException("There are no events to print.");
            }
            foreach (var events in _events)
            {
                Console.WriteLine(events.Value.ToString());
            }

        }

    }
}



