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
        private Dictionary<string, Blog> _blogs = new Dictionary<string, Blog>(BlogCollection.BlogsData);
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

        public Blog GetBlogByTitle(string title)
        {
            if (_blogs.ContainsKey(title))
            {
                return _blogs[title];
            }
            else
            {
                throw new ArgumentException($"Blog with this title {title} is not found ");
            }
        }


        public List<Blog> GetAll()
        {
            if (!_blogs.Any())
            {
                throw new ArgumentException("euyguydgqgd");
            }

            return _blogs.Values.ToList();
        }



        public void DeleteBlogByTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title), "Title cannot be empty.");
            }
            if (!_blogs.Keys.Contains(title))
            {
                _blogs.Remove(title);

            }
        }
       

        public void UpdateBlogByTitle(string title, string newTitle, string newDescription, DateTime newDate)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title), "Title cannot be empty.");
            }

            if (!_blogs.ContainsKey(title))
            {
                throw new KeyNotFoundException($"Blog with title '{title}' not found.");
            }

            Blog blog = _blogs[title];
            blog.Title = newTitle;
            blog.Description = newDescription;
            blog.Date = newDate;

            if (title != newTitle)
            {
                _blogs.Remove(title);
                _blogs.Add(newTitle, blog);
            }
        }



        public List<Blog> PrintAllBlogs()
        {
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
}