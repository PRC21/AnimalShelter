using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTests
{
    [TestClass]
    public class AdministrationTest
    {
        Administration testAdministration = new Administration();
        //private List<Animal> TestAnimals = new List<Animal>();
        Dog testHond = new Dog(1, new SimpleDate(15, 4, 2001), "bassie", new SimpleDate(16, 4, 2001));
        Cat testKat = new Cat(1, new SimpleDate(15, 4, 2001), "bassie", "Krabt veel");
        Cat testKat1 = new Cat(2, new SimpleDate(15, 4, 2001), "bassie", "Krabt veel");

        [TestMethod]
        public void TestAddAnimal()
        {
            testAdministration.Add(testHond);
            Assert.IsFalse(testAdministration.Add(testKat));
        }

        [TestMethod]
        public void TestAddAnimalNull()
        {
            testAdministration.Add(testHond);
            Assert.IsFalse(testAdministration.Add(null));
        }

        [TestMethod]
        public void TestFindAnimal()
        {
            testAdministration.FindAnimal(1);
            Assert.AreEqual(testAdministration.FindAnimal(1), (1, new SimpleDate(15, 4, 2001), "bassie", "Krabt veel");
        }
    }
}
