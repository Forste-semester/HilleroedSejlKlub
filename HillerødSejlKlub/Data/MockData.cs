using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public static class MockData
    {
        private static Dictionary<int, Member> _memberData = new Dictionary<int, Member>()
        {
            {1, new Member("Peter", "Peter90@mail.dk", "92929292", TitleType.BoardDirector) },
            {2, new Member("Rasmus", "Rasmus91@hotmail.com", "78787878", TitleType.BoardMember) },
            {3, new Member("Chris", "Chris78@gmail.com", "01010101", TitleType.Member) },
            {4, new Member("Michael", "Michael69@hotmail.com", "69696969", TitleType.Member) },
            {5, new Member("Hanne", "Hanne24@gmail.com", "45454545", TitleType.Secretary) }
        };

        public static Dictionary<int, Member> MemberData
        {
            get { return _memberData; }
        }
    }
}
