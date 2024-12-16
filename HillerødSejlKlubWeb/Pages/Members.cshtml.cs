using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlKlubWeb.Pages
{
    public class MembersModel : PageModel
    {
        private readonly UserRepository _userRepository;

        public Dictionary<int, User> Users { get; set; }

        public MembersModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void OnGet()
        {
            Users =_userRepository.GetAllUsers();
        }

        
    }
}
