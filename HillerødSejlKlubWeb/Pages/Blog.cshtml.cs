using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HillerødSejlKlub.Data;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HilleroedSejlKlubLibrary.Interfaces;

namespace HillerødSejlKlubWeb.Pages
{
    public class BlogModel : PageModel
    {
        private IBlogRepository _blogRepository;

        public BlogModel(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }


        public List<Blog> Blogs { get; set; }


        public void OnGet()
        {
            Blogs = _blogRepository.PrintAllBlogs();
        }


    }

}
