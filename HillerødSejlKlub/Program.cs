

﻿// See https://aka.ms/new-console-template for more information

using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Globalization;


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

Console.WriteLine("");
Console.WriteLine("Print again:");
boatRepository.PrintAllBoats();

boatRepository.AddBoat(new Boat("Hammer2", "Yamaha X-100", BoatType.SEJLBAAD, 1514, 35, 2020, false));

boatRepository.PrintAllBoats();


#endregion




