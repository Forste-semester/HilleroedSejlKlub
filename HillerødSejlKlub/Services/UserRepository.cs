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
            _users = new Dictionary<int, User>(MockData.UserData);
        }

        public void CreateUser(User user)
        {
            _users.Add(user.Id, user);
        }

        public Dictionary<int, User> GetAllUsers()
        {
            return _users;
        }

        public User GetUserById(int id)
        {
            if (_users.ContainsKey(id))
            {
                return _users[id];
            }
            else
            {
                return null;
            }
        }

        public void PrintAllUsers()
        {
            foreach (var user in _users.Values)
            {
                Console.WriteLine(user);
            }
        }

        public void RemoveUserById(int id)
        {
            _users.Remove(id);
        }

        public void UpdateUser(int id, string newName, string newEmail, string newPhone, TitleType newTitleType)
        {
            _users.ContainsKey(id);
            User user = _users[id];
            user.Name = newName;
            user.Email = newEmail;
            user.Phone = newPhone;
            user.TitleType = newTitleType;
        }
    }
}
