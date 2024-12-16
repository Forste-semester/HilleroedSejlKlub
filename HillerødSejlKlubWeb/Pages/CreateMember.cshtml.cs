using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlKlubWeb.Pages
{
    public class CreateMemberModel : PageModel
    {
        
        private readonly UserRepository _userRepository;
        public UserRepository UserRepository { get; set; }
        public Dictionary<int, User> Users { get; set; }

        [BindProperty]
        public User User { get; set; }

        // Input model for at oprette nye medlemmer
        [BindProperty]
        public int Id { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Phone { get; set; }

        [BindProperty]
        public TitleType TitleType { get; set; }

        public CreateMemberModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void OnGet()
        {
            Users = new Dictionary<int, User>();
            Users = _userRepository.GetAllUsers();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Not Valid");
            }
                if (ModelState.IsValid)
                {
                var newMember = new User(
                    Name,
                    Email,
                    Phone,
                    TitleType
                );
                Console.WriteLine("Valid");
                _userRepository.CreateUser(newMember);
                Users = _userRepository.GetAllUsers();
                foreach (var user in Users.Values) { Console.WriteLine(user.ToString()); }
                TempData["SuccessMessage"] = "Medlem blev oprettet!";
                return RedirectToPage("Members");
                }
            return Page();
        }
    }
}
