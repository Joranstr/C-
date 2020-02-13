using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1
{
    public class Person
    {
        

        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? BirthYear { get; set; }
        public int? ExpiredYear { get; set; }
        public string LastName { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public static List<Person> Persons { get; set; } = new List<Person>();

        public static void StandarPeople()
        {
            var sverreMagnus = new Person { Id = 1, FirstName = "Sverre Magnus", BirthYear = 2005 };
            var ingridAlexandra = new Person { Id = 2, FirstName = "Ingrid Alexandra", BirthYear = 2004 };
            var haakon = new Person { Id = 3, FirstName = "Haakon Magnus", BirthYear = 1973 };
            var metteMarit = new Person { Id = 4, FirstName = "Mette-Marit", BirthYear = 1973 };
            var marius = new Person { Id = 5, FirstName = "Marius", LastName = "Borg Høiby", BirthYear = 1997 };
            var harald = new Person { Id = 6, FirstName = "Harald", BirthYear = 1937 };
            var sonja = new Person { Id = 7, FirstName = "Sonja", BirthYear = 1937 };
            var olav = new Person { Id = 8, FirstName = "Olav", BirthYear = 1903, ExpiredYear = 1991};

            sverreMagnus.Father = haakon;
            sverreMagnus.Mother = metteMarit;
            ingridAlexandra.Father = haakon;
            ingridAlexandra.Mother = metteMarit;
            marius.Mother = metteMarit;
            haakon.Father = harald;
            haakon.Mother = sonja;
            harald.Father = olav;

            Persons.Add(haakon);
            Persons.Add(sverreMagnus);
            Persons.Add(ingridAlexandra);
            Persons.Add(metteMarit);
            Persons.Add(marius);
            Persons.Add(harald);
            Persons.Add(sonja);
            Persons.Add(olav);
        }

        public void show()
        {
            Console.WriteLine($"Id: {Id}");
            if(FirstName != null)Console.Write($"Navn: {FirstName} {LastName}\n");
            if(BirthYear.HasValue)Console.Write($"Fødsels år: {BirthYear} \n");
            if(ExpiredYear.HasValue)Console.Write($"Døds år: {ExpiredYear} \n");
            if(Father != null)Console.Write($"Fars navn: {Father.FirstName} id= {Father.Id}\n");
            if(Mother != null)Console.Write($"Mors navn: {Mother.FirstName} id= {Mother.Id} \n");
        }
    }
}
