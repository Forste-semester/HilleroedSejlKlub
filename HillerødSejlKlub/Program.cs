// See https://aka.ms/new-console-template for more information
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;































// Mads test






// Begge både bliver oprettet med forskelligt ID (1 og 2)



Boat myBoat = new Boat("Sejlbåden Hammer", "Model Yamaha X-100", BoatType.SEJLBAAD, 101, 30.5, 2020, false);
Boat myBoat2 = new Boat("Motorbåden Emilie", "Model Mustang X-500", BoatType.MOTORBAAD, 101, 30.5, 2020, false);
Boat myBoat3 = new Boat("Kajakken Ole", "Model Wavebreaker 3000", BoatType.KAJAK, 101, 30.5, 2023, true);
Boat myBoat4 = new Boat("Kajakken Frederikke", "Model Wavebreaker 5300", BoatType.KAJAK, 101, 30.5, 2023, true);

BoatRepository boatRepository = new BoatRepository();


Boat myBoat5 = new Boat("Sejlbåden Hammer II", "Model Yamaha X-100", BoatType.SEJLBAAD, 101, 30.5, 2020, false);

Dictionary<int, Boat> allBoats = boatRepository.PrintAllBoats();

Dictionary<int, Boat> allBoatsCollection = BoatCollection.PrintAllBoats(); 


Console.WriteLine("Alle både og deres detaljer:");


foreach (var boat in allBoats)
{
    Console.WriteLine($"--------------------\nID: {boat.Key}\nDetails:\n{boat.Value}\n---------------------");
}

Console.WriteLine("Nedenfor er Collection:");

foreach (var boat in allBoatsCollection)
{
    Console.WriteLine($"--------------------\nID: {boat.Key}\nDetails:\n{boat.Value}\n---------------------");
}

boatRepository.RemoveBoatByID(3);


Console.WriteLine("En gang til efter remove både og deres detaljer:");


foreach (var boat in allBoats)
{
    Console.WriteLine($"--------------------\nID: {boat.Key}\nDetails:\n{boat.Value}\n---------------------");
}

Console.WriteLine("Nedenfor er Collection:");

foreach (var boat in allBoatsCollection)
{
    Console.WriteLine($"--------------------\nID: {boat.Key}\nDetails:\n{boat.Value}\n---------------------");
}
Boat foundBoat = boatRepository.GetBoatByID(3);

if (foundBoat != null)
{
    Console.WriteLine($"Found Boat: {foundBoat.Name} ({foundBoat.Model})");
}
else
{
    Console.WriteLine("Boat not found.");
}



foreach (var boat in allBoatsCollection)
{
    Console.WriteLine($"--------------------\nID: {boat.Key}\nDetails:\n{boat.Value}\n---------------------");
}


Console.WriteLine("Nedenfor søger vi efter ID 4 og 5 på bådene");
Boat foundBoat2 = boatRepository.GetBoatByID(4);
Boat foundBoat3 = boatRepository.GetBoatByID(5);

if (foundBoat2 != null)
{
    Console.WriteLine($"Found Boat: {foundBoat2.Name} ({foundBoat2.Model})");
}
else
{
    Console.WriteLine("Boat not found.");
}

if (foundBoat3 != null)
{
    Console.WriteLine($"Found Boat: {foundBoat3.Name} ({foundBoat3.Model})");
}
else
{
    Console.WriteLine("Boat not found.");
}


// Noter, jeg ligger mærke til at når man fjerner en båd vil alle andre bådes ID ændres, er dette godt?