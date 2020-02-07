using System;
using System.Collections.Generic;
using System.Text;

namespace Oblig1
{
    class SlektstreClasse
    {
        private string father;
        private string mother;
        private string deathYear;
        private string birthYear;
        private string lastName;
        private string firstName;
        private string parent;
        private int id;


        public SlaktstreClasse(int id, string firstName, string lastName, string birthYear, string deathYear, string mother, string father)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.deathYear = deathYear;
            this.mother = mother;
            this.father = father;
        }

        public SlaktstreClasse(int id, string firstName, string lastName, string birthYear, string mother, string father)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.mother = mother;
            this.father = father;
        }

        public SlaktstreClasse(int id, string firstName, string lastName, string birthYear, string parent)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.parent = parent;
        }
        public SlaktstreClasse(int id, string firstName, string lastName, string birthYear)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
        }
        public SlaktstreClasse(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
