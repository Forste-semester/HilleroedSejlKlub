using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Linq.Expressions;


EventRepository eventRepository = new EventRepository();

eventRepository.PrintAllEvents();