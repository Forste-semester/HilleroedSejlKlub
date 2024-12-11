using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public class BlogCollection

    {
        private static Dictionary<string, Blog> _blogsData = new Dictionary<string, Blog>()
        {
            {"1 ", new Blog("New boats have been added", "5 new boats have been added to the boat list ", DateTime.Now ) },
            {"2", new Blog("Boat No. 5 is available again", "The boat number 5 has been fixed by replcing its engine with a new one.....", DateTime.Now ) },
            {"3", new Blog("New members are welcome", "There is room for new members in the club. Please share this film with friends and acquaintances who might be interested.", DateTime.Now ) },
            {"4", new Blog("Club Championship 2024", "Results for Club Championship 2023\r\n\r\nNiels Henrik no. 1 with 9 points\r\n\r\nHenrik no. 2 with 12 points\r\n\r\nPoul no. 2 with 12 points\r\n\r\nBrian no. 4 with 19 points\r\n\r\nLaurits no. 5 with 23 points\r\n\r\nWe had a lovely day on the water and sailed 5 regular races", DateTime.Now ) },
            {"5", new Blog("", "", DateTime.Now ) }

        };

        public static Dictionary<string, Blog> BlogsData
        {
            get { return _blogsData; }
        }
    }
}
