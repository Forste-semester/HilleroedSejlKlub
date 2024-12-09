using HilleroedSejlKlubLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Models
{
    public abstract class Engine : IEngine
    {
        public string Name { get; private set; }

        protected Engine(string name)
        {
            Name = name;
        }


        #region Methods

        

        public abstract string ToString();


        #endregion

    }
}
