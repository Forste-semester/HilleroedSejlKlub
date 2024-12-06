using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class BlogRepository : IBlogRepository
    {

        #region Instance Fields 
        private Dictionary<string, Blog> _blogs = new Dictionary<string, Blog>();
        #endregion


        #region Constructor
        public BlogRepository()
        {
            _blogs = new Dictionary<string, Blog>();

        }
        #endregion


        public void createBlog(Blog blog)
        {
            if (!_blogs.Keys.Contains(blog.Title))
            {
                _blogs.Add(blog.Title, blog);
            }
            throw new ArgumentException($"This Title alredy {blog.Title}exist");

        }


        // er Titlen på blog = id ???
        public Blog GetBlogById(string id)
        {
            if (!_blogs.Keys.Contains(id))
            {
                return _blogs[id];
            }
            else
            {
                throw new KeyNotFoundException($"Blog with this Id {id} is not found ");
            }
        }



        public void DeleteBlogById(string id)
        {
            if (!_blogs.Keys.Contains(id))
            {
                _blogs.Remove(id);
            }
            else
            {
                throw new KeyNotFoundException($"Blog with this Id {id} is not found ");

            }

        }

        public void UpdateBlogById(string id, Blog updatedBlog)
        {
            if (!_blogs.Keys.Contains(id))
            {
                _blogs[id] = updatedBlog;
            }
            else
            {
                throw new KeyNotFoundException($"Blog with this Id {id} is not found ");

            }
        }


        public void PrintAllBlogs()
        {

            if (_blogs == null)
            {
                return "No Blogs is found";
            }
            else foreach (Blog blog in _blogs.Values)
                {
                    Console.WriteLine();
                }
        }
    }
}