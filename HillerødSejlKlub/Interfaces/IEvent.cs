using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Interfaces
{
    internal interface IEvent
    {
        string Title { get; set;  }
        string Body { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        string Where { get; set; }
        string Creator { get; set; }
        string ToString();
    }
}
