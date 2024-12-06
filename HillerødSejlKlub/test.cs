using HillerødSejlKlub;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;




#region MadsTest

BoatRepository boatRepository = new BoatRepository();

// Print all boats 
boatRepository.PrintAllBoats();

// Update boat test
boatRepository.UpdateBoatByID(1, "NewName", "NewModel", BoatType.Wayfarer, 12.5);


// Update boat with details
boatRepository.UpdateBoatByID(3, "NewName", "NewModel", BoatType.Snipejolle, 12.5);


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

boatRepository.AddBoat(new Boat("Hammer", "Yamaha X-100", BoatType.Wayfarer, 35, 2020));

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
