using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using HilleroedSejlKlubLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    public interface IBlogRepository
    {
        void CreateBlog(Blog blog);
        Blog GetBlogByTitle(string title);
        void DeleteBlogByTitle(string title);

        void UpdateBlogByTitle(string title, string NewTitle, string NewDescription, DateTime NewDate);

        List<Blog> PrintAllBlogs();
        List<Blog> GetAll();
    }
}

