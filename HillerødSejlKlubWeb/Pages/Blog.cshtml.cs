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
    public class BlogModel : PageModel
    {
        private readonly BlogRepository _blogRepository;

        public List<Blog> BlogList { get; set; }



        public string ErrorMessage { get; set; }


        public BlogModel(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        
        public void OnGet()
        {
            try
            {
                BlogList = _blogRepository.GetAll();
            }
            catch (ArgumentException ex)
            {
                ErrorMessage = ex.Message;
            }
        }


    }

}
