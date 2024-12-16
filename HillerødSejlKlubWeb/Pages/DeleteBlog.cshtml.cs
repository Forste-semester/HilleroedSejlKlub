using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HillerødSejlKlub.Interfaces;



namespace HillerødSejlKlubWeb.Pages
{
    public class DeleteBlogModel : PageModel
    {
        
        private readonly BlogRepository _blogRepository;


        [BindProperty]
        public List<Blog> BlogList { get; set; }

        [BindProperty]
        public string Title { get; set; }

        [BindProperty]
        public string ErrorMessage { get; set; }

        [BindProperty]
        public string SuccessMessage { get; private set; }


        public DeleteBlogModel(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void OnGet()
        {
            BlogList = _blogRepository.GetAll();
        }

        public IActionResult OnPostDeleteBlogByTitle(string title)
        {
                try
                {
                    _blogRepository.DeleteBlogByTitle(title);
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return Page();
                }

                return RedirectToPage("/DeleteBlog");
            }

            /*
            var blog = BlogList.FirstOrDefault(b => b.Title == title);

            if (string.IsNullOrEmpty(title))
            {
                ModelState.AddModelError(string.Empty, "Blog title cannot be empty.");
                return RedirectToPage();
            }
            try
            {
                _blogRepository.DeleteBlogByTitle(title);
                BlogList.Remove(blog);
            }
            catch (ArgumentException)
            {
                ModelState.AddModelError(string.Empty, $"Somthing is wrong");
            }

            return RedirectToPage("/Blog");
        }*/

            /*
                var blog = BlogList.FirstOrDefault(b => b.Title == title);
                if (blog == null)
                {
                    ErrorMessage = $"No blog found with the title '{title}'.";
                    return Page();
                }

                _blogRepository.DeleteBlogByTitle(title);
                BlogList.Remove(blog); 
                SuccessMessage = "Blog removed successfully.";
                return RedirectToPage();
            }
            */


            /*
            public IActionResult OnPostDeletBlog(string title)
            {
                {
                    var blog = BlogList.FirstOrDefault(b => b.Title == title);
                    if (blog == null)
                    {
                        ErrorMessage = $"No blog found with the title '{title}'.";
                        return Page();
                    }

                    _blogRepository.DeleteBlogByTitle(title);
                    SuccessMessage = "Blog removed successfully.";
                    return RedirectToPage();
                }
            }
            */


        }
    }
