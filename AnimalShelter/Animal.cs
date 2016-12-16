using System;

namespace AnimalShelter
{
    [Serializable]
    public abstract class Animal : ISellable,IComparable<Animal>
    {
        public int CompareTo(Animal otherAnimal)
        {
            return ChipRegistrationNumber.CompareTo(otherAnimal.ChipRegistrationNumber);
        }
        public abstract decimal Price { get; }
        public int ChipRegistrationNumber { get; set; }
        public SimpleDate DateOfBirth { get; set; }
        public string Name { get; set; }
        public bool IsReserved { get; set; }

        protected Animal(int chipRegistrationNumber, SimpleDate dateOfBirth, string name)
        {
            if (chipRegistrationNumber == 0)
            {
                throw new ArgumentOutOfRangeException("ChipregistrationNumber moet groter zijn dan 0");
                
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            ChipRegistrationNumber = chipRegistrationNumber;
            DateOfBirth = dateOfBirth;
            Name = name;
            IsReserved = false;
        }

        public override string ToString()
        {
            string isReservedString;
            if (IsReserved)
            {
                isReservedString = "reserved";
            }
            else
            {
                isReservedString = "not reserved";
            }

            string info = ChipRegistrationNumber
                          + ", " + DateOfBirth
                          + ", " + Name
                          + ", " + isReservedString;
            return info;
        }
    }
}
