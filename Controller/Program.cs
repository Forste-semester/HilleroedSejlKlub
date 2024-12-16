using HillerødSejlKlub;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System.Linq.Expressions;


IBookingRepository bookingRepository = new BookingRepository();

bookingRepository.CreateBooking(new Booking(new User("Philip","syhlerp@gmail.com","61773517",TitleType.Member), new Boat("Kaktus","Chewbaka",BoatType.Optimistjolle,8,1990,"BZ5278"),DateOnly.Parse("13/12/2024"),18,"Ishøj") );