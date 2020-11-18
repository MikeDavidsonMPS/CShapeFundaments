using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class LoopsExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 15;

            //1 Starting point fires off only once
            //2 Condition that while true. keeps the loop running
            //3 What happens after each loop
            //4 Body of the loop, what happens eachiteration

            //for  //1      //2             //3
            for (int i = 0; i < studentCount; i++) // i = i + 1; -> i++
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Eleven Fifty Academy";

            //1 Collectio that's being worked on
            //2 Name of the current iteration being used
            //3 Current type in the collection
            //4 in keyword, used to seperate the individual and the collection
            //5 Body of the loop

            //foreach //3   //2  //4 //1
            foreach (char letter in name)
            {
                Console.WriteLine(letter); //5
            }  
        }

        [TestMethod]
        public void MyTestMethod()
        {

        }
  
    }
}
