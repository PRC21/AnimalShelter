using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace AnimalShelterTests
{
    [TestClass]
    public class AdministrationTest
    {
        Administration testAdministration = new Administration();
        //private List<Animal> TestAnimals = new List<Animal>();
        private readonly string fileName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" +
            "AnimalShelter.bin";
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
            testAdministration.Add(testKat1);
            testAdministration.FindAnimal(2);
            Assert.AreEqual(testAdministration.FindAnimal(2), (testKat1));
        }

        [TestMethod]
        public void TestExportFile()
        {
            testAdministration.Add(testHond);
            testAdministration.Add(testKat);
            string fileName = "export";
            testAdministration.Export(fileName);

            Assert.IsTrue(File.Exists(fileName));
        }

        [TestMethod]
        public void TestLoadFile()
        {
            List<Animal> loadedAnimals = new List<Animal>();
            loadedAnimals.Add(testHond);
            loadedAnimals.Add(testKat1);
            //CollectionAssert.AreEqual(loadedAnimals, testAdministration.Load(fileName) );
        }
    }
}
