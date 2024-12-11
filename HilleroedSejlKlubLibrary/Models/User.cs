using HillerødSejlKlub.Data;
using HillerødSejlKlub.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public class User : IUser
    {
        #region Instance Fields
        private static int _nextId = 1;
        #endregion
        #region Constructor
        public User(string name, string email, string phone, TitleType titleType)
        {
            Id = _nextId++;
            Name = name;
            Email = email;
            Phone = phone;
            TitleType = titleType;
        }
        #endregion
        #region Properties
        public int Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public TitleType TitleType { get; set; }
        #endregion
        #region Methods
        public override string ToString()
        {

            if (TitleType == TitleType.Board_Director)
            {
                return $"Name: {Name}\nEmail: {Email}\nPhone: {Phone}\nTitle: Board Director\nID: {Id}\n";
            }


            if (TitleType == TitleType.Board_Member)
            {
                return $"Name: {Name}\nEmail: {Email}\nPhone: {Phone}\nTitle: Board Member\nID: {Id}\n";
            }
            else
            {
                return $"Name: {Name}\nEmail: {Email}\nPhone: {Phone}\nTitle: {TitleType}\nID: {Id}\n";
            }
        }
        #endregion
    }
}
