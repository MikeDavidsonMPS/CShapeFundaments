﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {
            //-- Whole Numbers
            byte oneBytesWorth;
            oneBytesWorth = 255;
            short smallWholeNumber = 16;    //Int16
            Int16 anotherSmallNumber = 16;  //Int16         
            int wholeNumber = 32;           //Int32
            long largeWholeNumber = 64;     //Int64

            //-- Decimals
            float floatExample = 1.234567f;
            double doubleExample = 1.234567;
            decimal decimalExample = 1.7005m;

            //--Character
            char letter = 'j';


            //-- Operators
            int numOne = 17;
            int numTwo = 5;

            int sum = numOne + numTwo;
            Console.WriteLine(sum);
            int diff = numOne - numTwo;
            Console.WriteLine(diff);
            int prod = numTwo * numTwo;
            Console.WriteLine(prod);
            int quot = numOne / numTwo;
            Console.WriteLine(quot);
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            Console.WriteLine("hello");


        }

        [TestMethod]
        public void ReferenceTyps()
        {
            //--Strings
            string stringExample = "This is a string.";
            string name = "mike";

            string declared;
            declared = "Now it's initialized";

            // Formatting strings
            string concatenate = stringExample + "" + name;                       //This is a string.  mike
            string interpolate = $"{name}. here is the string: {stringExample}."; //mike. Here is the string: This is a string.
            Console.WriteLine(concatenate);
            Console.WriteLine(interpolate);

            //-- Other Object Examples
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime randomDate = new DateTime(2019, 6, 29);

            TimeSpan waitTime = randomDate - now;
            Console.WriteLine(waitTime.TotalSeconds);


            //--Collection
            // Arrays
            string anotherExampleString = "hello World";
            string[]stringArray = { anotherExampleString, "Hello", "World", "!" };
            string[]stundents = new string[15];

            Console.WriteLine(stringArray);

            // List
            List<string> listOfString = new List<string>();
            listOfString.Add("Lawrence");

            // Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("luke");

            // Distionaries
            Dictionary<char, string> keyValuePairs = new Dictionary<char, string>();
            keyValuePairs.Add('j', "josh");

            // Other Collections
            SortedList<int, string> sortedKeyValuePair = new SortedList<int, string>();
            Stack<string> firstInLastOut = new Stack<string>();


        }
    }
}
