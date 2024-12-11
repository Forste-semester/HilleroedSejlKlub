using HillerødSejlKlub;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlKlubWeb.Pages
{
    public class CreateBookingModel : PageModel
    {
        private readonly UserRepository _userRepository;
        public UserRepository UserRepository { get; private set; }
        private readonly BoatRepository _boatRepository;
        public Dictionary<int, Boat> Boats { get; private set; }
        public Dictionary<int, User> Users { get; private set; }
        private BookingRepository _bookingRepository;

        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public int BoatId { get; set; }

        [BindProperty]
        public DateOnly BookingDate { get; set; }

        [BindProperty]
        public int ReturnHour { get; set; }

        [BindProperty]
        public string Location { get; set; }
        public CreateBookingModel(UserRepository userRepository, BoatRepository boatRepository, BookingRepository bookingRepository)
        {
            _userRepository = userRepository;
            _boatRepository = boatRepository;
            _bookingRepository = bookingRepository;
        }

        public void OnGet()
        {
            Users = _userRepository.GetAllUsers() ;
            Boats = _boatRepository.GetAll();
        }


        public IActionResult OnPost()
        {
            User selectedUser = _userRepository.GetUserById(Id);
            Boat selectedBoat = _boatRepository.GetBoatByID(BoatId);

            var newBooking = new Booking(
                selectedUser,
                selectedBoat,
                BookingDate,
                ReturnHour,
                Location
            );
            _bookingRepository.CreateBooking(newBooking);
            return RedirectToPage("/Bookings");
        }
    }
}