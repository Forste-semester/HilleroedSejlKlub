using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class MemberRepository : IMemberRepository
    {
        private Dictionary<int, Member> _members;

        public MemberRepository()
        {
            _members = new Dictionary<int, Member>(MockData.MemberData);
        }

        public void CreateMember(Member member)
        {
            _members.Add(member.Id, member);
        }

        public Dictionary<int, Member> GetAllMembers()
        {
            foreach (var member in _members.Values)
            {
                Console.WriteLine(member);
            }
            return null;
        }

        public Member GetMemberById(int id)
        {
            return _members[id];
        }

        public void PrintAllMembers()
        {
            GetAllMembers();
        }

        public void RemoveMemberById(int id)
        {
            _members.Remove(id);
        }

        public void UpdateMember(Member member, string newName, string newEmail, string newPhone, TitleType newTitleType)
        {
            member.Name = newName;
            member.Email = newEmail;
            member.Phone = newPhone;
            member.TitleType = newTitleType;
        }
    }
}
