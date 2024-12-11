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
        Blog GetBlogById(string id);
        void DeleteBlogById(string id);

        void UpdateBlogById(string id, string NewId, string NewDescription, DateTime NewDate);

        List<Blog> PrintAllBlogs();
    }
}

