using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy_OOP
{
    class Human
    {
        public string firstName;
        public string lastName;
        private string eyeColor;
        private int age;

        //constructor
        public Human(string firstName, string lastName, string eyeColor,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public Human(string firstName, string eyeColor, int age)
        {
            this.firstName = firstName;
            //this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        public void introduceMyself()
        {
            Console.WriteLine($"hi I'm {firstName} {lastName} I'm {age} year old, and mye eyecolor are {eyeColor}");
        }
    }
}
