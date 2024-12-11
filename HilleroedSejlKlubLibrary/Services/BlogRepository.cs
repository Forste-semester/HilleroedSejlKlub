using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using HillerødSejlKlub.Models;
using HilleroedSejlKlubLibrary.Interfaces;
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
        private Dictionary<string, Blog> _blogs;
        #endregion


        #region Constructor
        public BlogRepository()
        {
            _blogs = new Dictionary<string, Blog>(BlogCollection.BlogsData);

        }
        #endregion


        public void CreateBlog(Blog blog)
        {
            if (!_blogs.Keys.Contains(blog.Id))
            {
                _blogs.Add(blog.Id, blog);
            }
            else
            {
            throw new ArgumentException($"This Title alredy {blog.Id}exist");

            }

        }


        
        public Blog GetBlogById(string id )
        {
            if (_blogs.ContainsKey(id))
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
            if (string.IsNullOrEmpty(id)) 
            {  
                throw new ArgumentNullException(nameof(id), "This felt cannot be empty..."); 
            }
           
            if (_blogs.ContainsKey(id))
            {
                _blogs.Remove(id);
            }
            else
            {
                throw new KeyNotFoundException($"Blog with this Id {id} is not found ");

            }

        }

        public void UpdateBlogById(string id, string NewId, string NewDescription, DateTime Newsdate)
        {
            _blogs.ContainsKey(id);
            Blog blog = _blogs[id];
            blog.Id = NewId;
            blog.Description = NewDescription;
            blog.Date= Newsdate;

            if (id != NewId)
            {
                _blogs.Remove(id);
                _blogs.Add(NewId, blog);

            }
        }


        public List<Blog> PrintAllBlogs()
        {
                if (_blogs == null)
                {
                    Console.WriteLine("No Blogs are found");
                }
                else foreach (Blog blog in _blogs.Values)
                    {
                        //Console.WriteLine(_blogs.Values.ToString()); 

                        Console.WriteLine($"Id: {blog.Id}, Description: {blog.Description}, Date: {blog.Date} ");
                    }
                return _blogs.Values.ToList();
        }
    }
}