using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelterTests
{
    [TestClass]
    public class CatTest
    {
        Administration testAdministration = new Administration();
        Cat testKat = new Cat(1, new SimpleDate(15, 4, 2001), "bassie", "Krabt veel");
        Cat testKat2 = new Cat(1, new SimpleDate(15, 4, 2001), "bassie", "");
        Cat testKat3 = new Cat(1, new SimpleDate(15, 4, 2001), "bassie", "abcdefghijklmnopqrstuvwxyz1234567890,./;'[]-=*");

        [TestMethod]
        public void CatConstructorTest()
        {
            bool testCat = testAdministration.Add(testKat);

            Assert.IsTrue(testCat, "Adding failed");
        }

        [TestMethod]
        public void EmptyToStringFuntion()
        {
            string wrongString = "Cat: 1, 15-04-2001, bassie, not reserved, Krabt veel, 5";
            Assert.AreNotEqual(testKat.ToString(), wrongString);
        }

        [TestMethod]
        public void ToStringFunction()
        {
            string filledString = "Cat: 1, 15-04-2001, bassie, not reserved, Krabt veel, 50";
            Assert.AreEqual(testKat.ToString(), filledString);
        }

        [TestMethod]
        public void ToStringFunctionNone()
        {
            string filledString = "Cat: 1, 15-04-2001, bassie, not reserved, none, 60";
            Assert.AreEqual(testKat2.ToString(), filledString);
        }

        [TestMethod]
        public void CalculatePriceWithEmptyBadHabits()
        {
            testKat2.CalculatePrice("");
            Assert.AreEqual(60, testKat2.Price);
        }

        [TestMethod]
        public void CalculatePriceNormal()
        {
            testKat2.CalculatePrice("Krabt veel");
            Assert.AreEqual(50, testKat.Price);
        }

        [TestMethod]
        public void CalculatePriceOverCharacterLimit()
        {
            testKat3.CalculatePrice("abcdefghijklmnopqrstuvwxyz1234567890,./;'[]-=*");
            Assert.AreEqual(20, testKat3.Price);
        }
    }   
}
