using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;






BoatRepository boatRepository = new BoatRepository();


boatRepository.PrintAllBoats();
boatRepository.GetBoatByID(1).PrintBoatLog();

boatRepository.GetBoatByID(2).PrintBoatLog();

boatRepository.GetBoatByID(3).PrintBoatLog();

boatRepository.GetBoatByID(4).PrintBoatLog();

boatRepository.GetBoatByID(5).PrintBoatLog();





