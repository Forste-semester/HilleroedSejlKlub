using HillerødSejlKlub.Models;
using HillerødSejlKlub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    public interface IBlogRepository
    {
        void createBlog(Blog blog);
        Blog GetBlogById(string id);
        void DeleteBlogById(string íd);

        void UpdateBlogById(string id, string NewId, string NewDescription, DateTime NewDate);

        void PrintAllBlogs(); 
        
    }
}

