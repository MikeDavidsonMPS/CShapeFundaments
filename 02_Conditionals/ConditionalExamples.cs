using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void Booleans()
        {
            bool isTrue = 17 > 5;
            bool isFalse = 17 == 4;
        }

        [TestMethod]
        public void ifElseStatements()
        {
            bool isTrue = true;
            if(true)
            {
             // Do Something here
            }

            int age = 12;

            if (age > 17)
            {
                Console.WriteLine("You're an adult");
            }
            else
            {
                Console.WriteLine("You're still a kid"); 
            }
            else if (age > 0)
            {
                Console.WriteLine("you're far too young to on the computer");
            }
            else
            {
                Console.WriteLine("you're not even born yet");
            }

            if (age > 65 && age < 18) 
            {
                // And comparison
            }

            if (age <= 65 || age >= 18) 
            {
                // Or Comparison ||
            }

            if (age ==17)
            {
                // Is equal to
            }

            if (age != 19)
            {
                // Not Equals to
                // !bang operator
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 42;

            switch (age)
            {
                case 18:
                    // Code for if age is 18
                    break;
                case 19:
                    // Code for if 19
                    break;
                case 20:
                    // Code for if age is 20
                    break;
                case 21:
                case 22:
                case 23:
                    // Code here for 21-23
                    break;
                default:
                    // Catch all code
                    Console.WriteLine("you are not 18-23");
                    break;
            }
        }
        [TestMethod]
        public void Ternaries()
        {
            int age = 37;

            // bool someVariable = (boolean statement) ? trueValue : falseValue;

            bool is Age = (age == 24) ? true : false;
        }
    }
}
