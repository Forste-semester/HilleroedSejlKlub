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
        #region Methods
        void createBlog(Blog blog);
        Blog GetBlogById(string id);
        void DeleteBlogById(string id);
        void UpdateBlogById(string id, Blog newBlog);
        void PrintAllBlogs();
        #endregion
    }
}

