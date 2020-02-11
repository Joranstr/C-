using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1
{
    public class Person
    {
        

        public int Id { get; set; }
        public string FirstName { get; set; }
        public int BirthYear { get; set; }
        public string LastName { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }
    }
}
