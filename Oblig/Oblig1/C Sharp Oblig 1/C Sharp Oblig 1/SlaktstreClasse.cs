using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Oblig_1
{
    class SlaktstreClasse
    {
        private string father;
        private string mother;
        private string deathYear;
        private string birthYear;
        private string lastName;
        private string firstName;
        

        public SlaktstreClasse(string firstName,string lastName,string birthYear,string deathYear,string mother,string father)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.deathYear = deathYear;
            this.mother = mother;
            this.father = father;
        }

        public SlaktstreClasse(string firstName, string lastName, string birthYear, string mother, string father)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthYear = birthYear;
            this.mother = mother;
            this.father = father;
            //this.newGuid();
        }
    }
}
