using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Models;



Engine diesel = new DieselEngine("Bladt Diesel", 24);

Engine elMotor = new ElectricEngine("Ultra Minn Kota Endura", 34);

Engine benzinMotor = new GasEngine("Mercruiser", 20, 8);

Boat Myboat = new Boat("Hammer", "Yamaha X-100", BoatType.Sejlbåd, 35, 2020, "DY2461", diesel);

Boat Myboat2 = new Boat("Hammer", "Yamaha X-100", BoatType.Sejlbåd, 35, 2020, "DY2461");




string boat = Myboat.ToString();


string boat2 = Myboat2.ToString();

Console.WriteLine($"{boat}");

Console.WriteLine($"{boat2}");