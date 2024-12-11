using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HillerødSejlKlubWeb.Pages
{
    public class MembersModel : PageModel
    {
        private readonly ILogger<MembersModel> logger;
        private readonly UserRepository _userRepository;

        public Dictionary<int, User> UserList { get; set; }

        public MembersModel(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void OnGet()
        {
            UserList =_userRepository.GetAllUsers();
        }

    }
}
