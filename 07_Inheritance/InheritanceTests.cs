using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            //var person = new Person();
            //person.Firstname = "Joshua";
            //person.ToString();

            var customer = new Customer(true, "Josh", "Tucker", "12345678910", "jticker@elevenfifty.org");
            customer.ToString();
            customer.Firstname = "Lawerence";
            customer.IsPremium = true;

            var empolyee = new Employee();
            empolyee.Firstname = "Luke";
            empolyee.HireDate= DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();


            List<Person> people = new List<Person>();


            List<int> numbers = new List<int>();
            people.Add(customer);
            people.Add(empolyee);
            people.Add(hourlyEmployee);
        }
    }
}
