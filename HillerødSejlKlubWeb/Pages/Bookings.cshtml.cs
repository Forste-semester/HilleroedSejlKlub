using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlKlubWeb.Pages
{
    public class BookingsModel : PageModel
    {

        private BookingRepository _bookingRepository;

        public Dictionary<int, Booking> BookingsAsDictionary { get; private set; }
        public Dictionary<int, Booking> Bookings { get; private set; }

        public BookingsModel(BookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public void OnGet()
        {
            Bookings = _bookingRepository.GetAll();
            _bookingRepository.LeaveDock(2);
        }

        public void OnPost() 
        { 
        
        }
    }
}
