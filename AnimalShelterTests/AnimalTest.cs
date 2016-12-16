using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTests
{
    [TestClass]
    public class AnimalTest
    {
        Dog testHond = new Dog(1, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Dog testHond5 = new Dog(2, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Dog testHond2 = new Dog(50011, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Dog testHond3 = new Dog(5004, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2000));
        Dog testHond4 = new Dog(18, new SimpleDate(15, 4, 2001), "bassie", null);
        [TestMethod]
        public void ReservedStringTest()
        {
            testHond.IsReserved = true;
            string filledString = "Dog: 1, 15-04-2001, bassie, reserved, 16-04-2001, 200";
            Assert.AreEqual(testHond.ToString(), filledString);
        }

        [TestMethod]
        public void CompareToTest()
        {
            List<Animal> AnimalTestSorted = new List<Animal>();
            List<Animal> AnimalTestUnSorted = new List<Animal>();

            AnimalTestSorted.Add(testHond);
            AnimalTestSorted.Add(testHond5);
            AnimalTestSorted.Add(testHond4);
            AnimalTestSorted.Add(testHond3);
            AnimalTestSorted.Add(testHond2);

            AnimalTestUnSorted.Add(testHond);
            AnimalTestUnSorted.Add(testHond5);
            AnimalTestUnSorted.Add(testHond2);
            AnimalTestUnSorted.Add(testHond4);
            AnimalTestUnSorted.Add(testHond3);
            AnimalTestUnSorted.Sort();

            CollectionAssert.AreEqual(AnimalTestSorted, AnimalTestUnSorted);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAnimalArgumentNullException()
        {
            Dog testHond4 = new Dog(18, new SimpleDate(15, 4, 2001), null, new SimpleDate(16, 4, 2000));
        }
    }
}
