using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOwner;

namespace UnitTestCar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAntalDoors()
        {
            //Arrange
            var testCar1 = new Car(4, "BMW", "AB34567");

            //Act
            int antalDoors = testCar1.TjekDoors();

            //Assert
            Assert.AreEqual(4, antalDoors);
        }

        [TestMethod]
        public void TestNummerplade()
        {
            //Arrange
            var testCar2 = new Car(5, "BMW", "AB34567");

            //Act
            string nummerplade = testCar2.TjekNummerplade();

            //Assert
            Assert.AreEqual("AB34567", nummerplade);
        }

        [TestMethod]
        public void TestBilModel()
        {
            //Arrange
            var testCar3 = new Car(5, "BMW", "AB34567");

            //Act
            string bilmodel = testCar3.TjekBilModel();

            //Assert
            Assert.AreEqual("BMW", bilmodel);
        }
    }
}
