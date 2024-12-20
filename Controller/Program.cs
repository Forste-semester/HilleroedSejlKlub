

using Hiller�dSejlKlub.Models;
using Hiller�dSejlKlub.Services;

BoatRepository boatRepository = new BoatRepository();

Boat boat = new Boat("Test", "Tesla", Hiller�dSejlKlub.Data.BoatType.Sejlb�d, 34, 1994, "324242");

boatRepository.AddBoat(boat);

List<Boat> boatList = new List<Boat>();   

Dictionary<int, Boat> boats = boatRepository.GetAll();

foreach (var entry in boats)
{

    int id = entry.Key;
    Console.WriteLine(entry);
}

boatRepository.UpdateBoatByID(3, "test2", "testmodel2", Hiller�dSejlKlub.Data.BoatType.TERA, 14);

foreach (var entry in boats)
{

    int id = entry.Key;
    Console.WriteLine(entry.Value);
}


