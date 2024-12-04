using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IMemberRepository
    {
        Dictionary<int, Member> GetAllMembers();
        void CreateMember(Member member);
        void UpdateMember(Member member, string name, string email, string phone, TitleType titleType);
        void RemoveMemberById(int id);
        Member GetMemberById(int id);
        void PrintAllMembers();
    }
}