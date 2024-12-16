using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub
{
    public interface IUserRepository
    {
        #region Methods
        Dictionary<int, User> GetAllUsers();
        void CreateUser(User user);
        void UpdateUser(int id, string name, string email, string phone, TitleType titleType);
        void RemoveUserById(int id);
        User GetUserById(int id);
        void PrintAllUsers();
        #endregion
    }
}