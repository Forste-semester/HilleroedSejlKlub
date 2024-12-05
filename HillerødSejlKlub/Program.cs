using HillerødSejlKlub;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;

EventRepository eventRepository = new EventRepository();
UserRepository userRepository = new UserRepository();
BoatRepository boatRepository = new BoatRepository();


Boat myBoat = new Boat("Sea Breeze", "Model X", BoatType.MOTORBAAD, 12345, 30.5, 2020);
Maintenance maintenance = new Maintenance("Painted windows", 350, new DateOnly(2024,12,5));
Maintenance maintenance1 = new Maintenance("Oil change", 25, new DateOnly(2024, 12, 5));


myBoat.AddMaintenance(maintenance);

myBoat.PrintBoatLog();

myBoat.AddMaintenance(maintenance1);

myBoat.PrintBoatLog();







boatRepository.AddBoat(myBoat);
boatRepository.PrintBoats();


eventRepository.PrintAllEvents();
userRepository.PrintAllUsers();


User testuser = new User("Chris", "Chris78@gmail.com", "01010101", TitleType.Member);
Event testevent = new Event("Test", "Test.", "21-12-2024", "14:00", "Klubhuset", "Chris", 5000);

eventRepository.AddEvent(testevent);

eventRepository.JoinEvent("Test", testuser);

eventRepository.PrintParticipants("Test");

eventRepository.RemoveFromEvent("Test", testuser);

eventRepository.PrintParticipants("Test");

eventRepository.PrintAllEvents();

eventRepository.EditEvent(testevent, "edittest", "edit21-12-2024", "edit14:00", "editKlubhuset", "editChris", 5000);

eventRepository.PrintAllEvents();

Console.WriteLine(testevent.ToString());
Console.WriteLine(eventRepository.GetEventByTitle("Test"));






