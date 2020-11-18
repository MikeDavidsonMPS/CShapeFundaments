using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void CookieTests()
        {
            Cookie cookie = new Cookie();
            cookie.Name = "snickerdoole";
            cookie.HasNuts = false;

            Cookie anotherCookie = new Cookie();
            anotherCookie.Name = "something else";
            anotherCookie.GramsOfFlour = 10;

            Cookie snickerdoole = new Cookie("Snickerdoole", false, 11.2);
            Cookie newCookie = new Cookie("Peanut Butter", true, 150);


        }

        [TestMethod]
        public void VehicleTests()
        {
            Vehicle car = new Vehicle();
            car.TypeOfVehicle = VehicleType.Car;

            Vehicle newCar = new Vehicle
            {
                TypeOfVehicle = VehicleType.Motorcycle,
                Make = "Honda",
                Model = "Civic",
            };

        }
    }
}
