using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOwner;


namespace UnitTestOwner
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdresseMatch()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "12345678");

            //Act
            string adresse = testOwner.TjekAdresse();

            //Assert
            Assert.AreEqual("Broholm 45", adresse);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AdresseTestForAntalTegn()
        {
            //Arrange
            var testOwner = new Owner("", "Oscar", "12345678");

            //Act
            string antalTegn = testOwner.TjekAdresse();
        }

        [TestMethod]
        public void TestNavneMatch()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "12345678");

            //Act
            string navn = testOwner.TjekNavn();

            //Assert
            Assert.AreEqual("Oscar", navn);
        }

        [TestMethod]
        public void TestNavneMatch2()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Otto", "12345678");

            //Act
            string navn = testOwner.TjekNavn();

            //Assert
            Assert.AreEqual("Otto", navn);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NavnTestForAntalTegn()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "", "12345678");

            //Act
            string antalTegn = testOwner.TjekNavn();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NavnTestForAntalTegn2()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Abc", "12345678");

            //Act
            string antalTegn = testOwner.TjekNavn();
        }

        [TestMethod]
        public void TestTelefonMatch()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "12345678");

            //Act
            string navn = testOwner.TjekTelefon();

            //Assert
            Assert.AreEqual("12345678", navn);
        }

        [TestMethod]
        public void TestTelefonBogstaver()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "12345678");

            //Act
            string navn = testOwner.TjekTelefon();

            //Assert
            Assert.AreEqual("12345678", navn);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTelefonForAntalTegn()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTelefonForAntalTegn2()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "1234567");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestTelefonForBogstaver()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "Abcdefgh");

            //Act
            string navn = testOwner.TjekTelefon();
        }
    }
}
