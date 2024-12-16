using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilleroedSejlKlubLibrary.Interfaces
{
    public interface IBlog

    {
        string Id { get; set; }
        string Description { get; set; }
        DateTime Date { get; set; }

        string ToString();
    }
}

