using HillerødSejlKlub.Data;
using HillerødSejlKlub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Services
{
    public class UserRepository : IUserRepository
    {
        private Dictionary<int, User> _users;

        public UserRepository()
        {
            _users = new Dictionary<int, User>(UserCollection.UserData);
        }

        public void CreateUser(User user)
        {
            _users.Add(user.Id, user);
        }

        public Dictionary<int, User> GetAllUsers()
        {
            foreach (var user in _users.Values)
            {
                Console.WriteLine(user);
            }
            return null;
        }

        public User GetUserById(int id)
        {
            return _users[id];
        }

        public void PrintAllUsers()
        {
            GetAllUsers();
        }

        public void RemoveUserById(int id)
        {
            _users.Remove(id);
        }

        public void UpdateUser(User user, string newName, string newEmail, string newPhone, TitleType newTitleType)
        {
            user.Name = newName;
            user.Email = newEmail;
            user.Phone = newPhone;
            user.TitleType = newTitleType;
        }
    }
}
