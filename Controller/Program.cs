using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Models;



BoatRepository boatRepository = new BoatRepository();
List<Boat> sailBoats = boatRepository.FilterBoat(BoatType.Sejlbåd);

List<Boat> motorBoats = boatRepository.FilterBoat(BoatType.Europajolle);

foreach (var boat in sailBoats)
{
    Console.WriteLine(boat.ToString());
}
foreach (var boat in motorBoats)
{
    Console.WriteLine(boat.ToString());
}

BoatRepository.