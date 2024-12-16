using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlubLibrary.Interfaces;

namespace HillerødSejlKlubWeb.Pages
{
    public class UpdateBlogModel : PageModel
    {

        private readonly BlogRepository _blogRepository;

        public List<Blog> BlogList { get; set; }

        [BindProperty]
        public string Id { get; set; }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public DateTime Date { get; set; }

        [BindProperty]
        public string ErrorMessage { get; set; }

        public UpdateBlogModel(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void OnGet()
        {
            BlogList = _blogRepository.GetAll();
        }

        public IActionResult OnPostUpdateBlogByTitile(string Title, string newId, string newDescription, DateTime newDate)
        {
            try
            {
                _blogRepository.UpdateBlogByTitle(Title, newId, newDescription, newDate);
                return RedirectToPage("/Blog");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return Page();
            }

        }
    }
}