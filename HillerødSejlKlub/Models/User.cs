using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class User
    {
        private string name;
        public User(string name)
        {
            Name = name;
        }
        public string Name { get; set; }    
    }
}
