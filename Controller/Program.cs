

using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;

BoatRepository boatRepository = new BoatRepository();

Boat boat = new Boat("Test", "Tesla", HillerødSejlKlub.Data.BoatType.Sejlbåd, 34, 1994, "324242");



boatRepository.AddBoat(boat);

List<Boat> boatList = new List<Boat>();   

Dictionary<int, Boat> boats = boatRepository.GetAll();

foreach (var entry in boats)
{

    int id = entry.Key;
    Console.WriteLine(entry);
}

for (int j = 0; j < 5; j++) 
{
    Console.WriteLine(j);
}

Console.WriteLine("below is while loop boats");

int boats2 = 0; // Initialize the loop variable
while (boats2 < boats.Count) // Loop condition
{

    var entry = boats[boats2];
   
    Console.WriteLine(entry);
    boats2++; // Increment the loop variable
}

boatRepository.UpdateBoatByID(3, "test2", "testmodel2", HillerødSejlKlub.Data.BoatType.TERA, 14);

Console.WriteLine("--------------");

foreach (var entry in boats)
{

    int id = entry.Key;
    Console.WriteLine(entry.Value);
}

Maintenance maintenance = new Maintenance(boat, "Replaced rudder", 1500.0);

BoatMaintenanceLog.Save("maintenance");


Maintenance maintenance2 = new Maintenance(boat, "New steering", 1000.0);


boatRepository.AddMaintenanceToBoat(4, new Maintenance(boat, "Test repair", 1500.00));

BoatMaintenanceLog.PrintLog();



