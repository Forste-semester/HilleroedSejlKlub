using HillerødSejlKlub.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    public interface IMember
    {
        string Name { get; }
        string Email { get; }
        string Phone { get; }
        int Id { get; }
        TitleType TitleType { get; }
        string ToString();
    }
}
