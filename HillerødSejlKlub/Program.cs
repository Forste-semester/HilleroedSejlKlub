using HillerødSejlKlub;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;


#region KristianTest

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

eventRepository.EditEvent("Test", "edittest", "edit21-12-2024", "edit14:00", "editKlubhuset", "editChris", 5000);

eventRepository.PrintAllEvents();

#endregion

#region MadsTest

BoatRepository boatRepository = new BoatRepository();

// Print all boats 
boatRepository.PrintAllBoats();

// Update boat test
boatRepository.UpdateBoatByID(1, "NewName", "NewModel", BoatType.KANO, 1523, 12.5, 2022, false);


// Update boat with details
Console.WriteLine(boatRepository.UpdateBoatByID(3, "NewName", "NewModel", BoatType.KANO, 1523, 12.5, 2022, false));


// Print updated boat list
boatRepository.PrintAllBoats();


// Print boat by ID

Boat boat = boatRepository.GetBoatByID(1);

Console.WriteLine($"Boat: {boat}");

// Remove boat by ID
Console.WriteLine("");
Console.WriteLine("Removed 1 below -----------");
Console.WriteLine("");
boatRepository.RemoveBoatByID(1);
Console.WriteLine("");
Console.WriteLine("Print again:");
boatRepository.PrintAllBoats();

// Add 1 back again

Console.WriteLine("Added 1 below again, now has ID of 6  -----------");

boatRepository.AddBoat(new Boat("Hammer", "Yamaha X-100", BoatType.SEJLBAAD, 1514, 35, 2020, false));

#endregion

#region BookingRepository Testing

BookingRepository bookingRepository = new BookingRepository();
bookingRepository.PrintAllBookings();

bookingRepository.LeaveDock(1);
bookingRepository.UpdateBookingById(6,2024,12,4,15);
bookingRepository.RemoveBookingById(4);
bookingRepository.LeaveDock(3);
Console.WriteLine(bookingRepository.GetBookingById(6));
Console.WriteLine(bookingRepository.GetAll());


bookingRepository.ReturnedToDock(1);
bookingRepository.PrintAllBookings();
#endregion
