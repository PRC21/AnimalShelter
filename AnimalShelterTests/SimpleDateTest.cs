using AnimalShelter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalShelterTests
{
    [TestClass]
    public class SimpleDateTest
    {
        [TestMethod]
        public void DaysDifferenceTest()
        {
            Dog testSimpleDateDog = new Dog(1, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
            SimpleDate testDate = new SimpleDate(16, 4, 2001);
            Assert.AreNotEqual(testSimpleDateDog.LastWalkDate.Day, testDate.DaysDifference(testDate));
        }
    }
}
