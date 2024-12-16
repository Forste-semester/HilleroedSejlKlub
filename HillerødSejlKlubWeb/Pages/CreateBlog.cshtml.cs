using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlubLibrary.Interfaces;
using HillerødSejlKlub;

namespace HillerødSejlKlubWeb.Pages
{
    public class CreateBlogModel : PageModel
    {
        private readonly BlogRepository _blogRepository;



        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string Id {  get; set; }
        
        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public DateTime Date { get; set; }

        public string ErrorMessage { get; set; }




        public CreateBlogModel(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;

        }

    

        public IActionResult OnPost()
        {
        
            try
            {
                var NewBlog = new Blog(Title, Description, DateTime.Now);

                _blogRepository.CreateBlog(NewBlog);
                return RedirectToPage("/Blog");
            }
            catch (ArgumentException ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return Page();

        }




    }

}
