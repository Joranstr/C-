using System;
using System.Collections.Generic;
using System.Text;

namespace Startliste
{
    class Club
    {

        public string Name { get; private set; }
        public List<Registration> Registration { get; private set; }

        public Club(string name)
        {
            Name = name;
            Registration = new List<Registration>();
        }

        public void Add(Registration registration)
        {
            //throw new NotImplementedException();
        }
    }
}
