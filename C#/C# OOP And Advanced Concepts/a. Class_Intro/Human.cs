using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Intro
{
    class Human
    {
        // why private? https://softwareengineering.stackexchange.com/questions/143736/why-do-we-need-private-variables
        private int age;
        private string firstName;
        private string lastName;
        private string eyeColor;
        private bool isHuman = true;

        public Human(int theAge, string firstName, string lastName, string eyeColor)
        {
            age = theAge;
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }


        public void IntroduceOnceself()
        {
            Console.WriteLine("My name is {0} {1}, and my eye color is {2}", firstName, lastName, eyeColor);

        }


    }
}
