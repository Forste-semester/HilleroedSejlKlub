using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public static class UserCollection
    {
        private static Dictionary<int, User> _userData = new Dictionary<int, User>()
        {
            {1, new User("Peter", "Peter90@mail.dk", "92929292", TitleType.Board_Director) },
            {2, new User("Rasmus", "Rasmus91@hotmail.com", "78787878", TitleType.Board_Member) },
            {3, new User("Chris", "Chris78@gmail.com", "01010101", TitleType.Member) },
            {4, new User("Michael", "Michael69@hotmail.com", "69696969", TitleType.Member) },
            {5, new User("Hanne", "Hanne24@gmail.com", "45454545", TitleType.Secretary) }
        };

        public static Dictionary<int, User> UserData
        {
            get { return _userData; }
        }
    }
}
