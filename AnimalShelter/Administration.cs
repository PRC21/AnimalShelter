using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Windows.Forms;


namespace AnimalShelter
{
    [Serializable]
    public class Administration
    {
       
        public List<Animal> Animals { get; private set; }
        BinaryFormatter binaryFormatter =  new BinaryFormatter();

        public Administration()
        {
            Animals = new List<Animal>();
        }
        public bool Add(Animal animal)
        {
            if(animal == null)
            {
                return false;
            }
            else
            {
                if (FindAnimal(animal.ChipRegistrationNumber) != null)
                {
                    return false;
                }
                else
                {
                    Animals.Add(animal);
                    Animals.Sort();
                    return true;
                }
            }
            
        }

        public bool RemoveAnimal(int chipRegistrationNumber)
        {
            if (FindAnimal(chipRegistrationNumber) != null)
            {
                Animals.Remove(FindAnimal(chipRegistrationNumber));
                Animals.Sort();
                return true;
            }
            else
            {
                return false;
            }
        }

        public Animal FindAnimal(int chipRegistrationNumber)
        {
            //Als het dier gevonden is return je de info er over terug.
            if (chipRegistrationNumber >= 1)
            {
                foreach (Animal existingAnimal in Animals)
                {
                    if (existingAnimal.ChipRegistrationNumber == chipRegistrationNumber)
                    {
                        return existingAnimal;
                    }
                }
            }
            return null;
        }

        public void Save(string fileName)
        {
            #region CheckFile

            CheckFile(fileName);
            if (!File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            #endregion

            using (Stream streamWrite = File.Open(fileName, FileMode.Create))
            {
                try
                {
                    binaryFormatter.Serialize(streamWrite, Animals);
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                streamWrite.Close();
            }
        }

        public void Load(string fileName)
        {
            CheckFile(fileName);

            using (Stream streamRead = File.OpenRead(fileName))
            {
                try
                {
                    Animals = binaryFormatter.Deserialize(streamRead) as List<Animal>;
                }
                catch (ArgumentNullException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (SecurityException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void Export(string fileName)
        {
            CheckFile(fileName);

            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                foreach (Animal existingAnimal in Animals)
                {
                    if (existingAnimal is Dog)
                    {
                        streamWriter.WriteLine("Dog: " + existingAnimal.ToString());
                    }
                    else if (existingAnimal is Cat)
                    {
                        streamWriter.WriteLine("Cat: " + existingAnimal.ToString());
                    }
                }
            }
        }

        public static void CheckFile(string fileName)
        {
            if (fileName.Trim().Length <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
