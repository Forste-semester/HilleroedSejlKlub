using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace HillerødSejlKlubWeb.Pages
{
    public class BlogDetailsModel : PageModel
    {
        public Blog Blog { get; set; }




        public IActionResult OnGet(string id)
        {
            var blogRepository = new BlogRepository(); 
            Blog = blogRepository.GetAll().FirstOrDefault(b => b.Id == id);

            if (Blog == null)
            {
                return RedirectToPage("/Blog");
            }

            return Page();
        }
    }
}
