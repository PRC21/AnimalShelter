using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTests
{
    [TestClass]
    public class DogTest
    {
        Administration testAdministration = new Administration();
        Dog testHond = new Dog(1, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Dog testHond2 = new Dog(50001, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Dog testHond3 = new Dog(50001, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2000));
        Dog testHond4 = new Dog(1, new SimpleDate(15, 4, 2001), "bassie", null);

        [TestMethod]
        public void DogConstructorTest()
        {
            bool testDog = testAdministration.Add(testHond);
            Assert.IsTrue(testDog, "adding Failed");
        }

        [TestMethod]
        public void EmptyToStringFuntion()
        {
            string wrongString = "Dog: 1, 15-04-2001, bassie, not reserved, 16-04-2001, 20";
            Assert.AreNotEqual(testHond.ToString(), wrongString);
        }

        [TestMethod]
        public void ToStringFunction()
        {
            string filledString = "Dog: 1, 15-04-2001, bassie, not reserved, 16-04-2001, 200";
            Assert.AreEqual(testHond.ToString(), filledString);
        }

        [TestMethod]
        public void CalculatePriceInRange()
        {
            testHond.CalculatePrice(1);
            Assert.AreEqual(200, testHond.Price);
        }

        [TestMethod]
        public void CalculatePriceOutOfRange()
        {
            testHond2.CalculatePrice(50001);
            Assert.AreEqual(350, testHond2.Price);
        }

        [TestMethod]
        public void CorrectLastWalkDate()
        {
            SimpleDate testLastWalkDate = new SimpleDate(16, 4, 2001);
            Assert.AreEqual(testLastWalkDate.Day, testHond.LastWalkDate.Day);
            Assert.AreEqual(testLastWalkDate.Month, testHond.LastWalkDate.Month);
            Assert.AreEqual(testLastWalkDate.Year, testHond.LastWalkDate.Year);
        }

        [TestMethod]
        public void IncorrectLastWalkDate()
        {
            SimpleDate testLastWalkDate = new SimpleDate(16, 4, 2001);
            Assert.AreEqual(testLastWalkDate.Day, testHond3.LastWalkDate.Day);
            Assert.AreEqual(testLastWalkDate.Month, testHond3.LastWalkDate.Month);
            Assert.AreNotEqual(testLastWalkDate.Year, testHond3.LastWalkDate.Year);
        }

        [TestMethod]
        public void LastWalkDateUnknown()
        {
            string filledString = "Dog: 1, 15-04-2001, bassie, not reserved, Unknown, 200";
            Assert.AreEqual(testHond4.ToString(), filledString);
        }
    }
}
