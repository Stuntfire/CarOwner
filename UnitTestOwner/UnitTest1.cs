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
        [ExpectedException(typeof(AddressException))]
        public void AdresseTestFor_0_Tegn()
        {
            //Arrange
            var testOwner = new Owner("", "Oscar", "12345678");

            //Act
            string antalTegn = testOwner.TjekAdresse();
        }

        [TestMethod()]
        [ExpectedException(typeof(AddressException))]
        public void AdresseTestFor_6_Tal()
        {
            //Arrange
            var testOwner = new Owner("123456", "Oscar", "12345678");

            //Act
            string antalTegn = testOwner.TjekAdresse();
        }

        [TestMethod()]
        [ExpectedException(typeof(AddressException))]
        public void AdresseTestFor_6_Bogstaver()
        {
            //Arrange
            var testOwner = new Owner("123456", "Oscar", "Abcdef");

            //Act
            string antalTegn = testOwner.TjekAdresse();
        }

        [TestMethod()]
        [ExpectedException(typeof(AddressException))]
        public void AdresseTestFor_6_BogstaverOgTal()
        {
            //Arrange
            var testOwner = new Owner("123456", "Oscar", "Abc123");

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
            var testOwner = new Owner("Broholm 45", "Helle-Helle", "12345678");

            //Act
            string navn = testOwner.TjekNavn();

            //Assert
            Assert.AreEqual("Helle-Helle", navn);
        }

        [TestMethod()]
        [ExpectedException(typeof(NameException))]
        public void NavnTestForAntalTegn()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "", "12345678");

            //Act
            string antalTegn = testOwner.TjekNavn();
        }

        [TestMethod()]
        [ExpectedException(typeof(NameException))]
        public void NavnTestForAntalTegn2()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Abcd", "12345678");

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
        [ExpectedException(typeof(PhoneException))]
        public void TestTelefonForAntalTegn()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(PhoneException))]
        public void TestTelefonForAntalTegn2()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "1234567");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(PhoneException))]
        public void TestTelefonFor_8_Bogstaver()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "Abcdefgh");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(PhoneException))]
        public void TestTelefonForMindreEnd_8_Bogstaver()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "Abcdefg");

            //Act
            string navn = testOwner.TjekTelefon();
        }

        [TestMethod]
        [ExpectedException(typeof(PhoneException))]
        public void TestTelefonForMereEnd_8_Bogstaver()
        {
            //Arrange
            var testOwner = new Owner("Broholm 45", "Oscar", "Abcdefghi");

            //Act
            string navn = testOwner.TjekTelefon();
        }
    }
}
