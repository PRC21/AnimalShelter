using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    [Serializable]
    public class Dog : Animal
    {
        public SimpleDate LastWalkDate { get; set; }
        public override decimal Price { get { return CalculatePrice(ChipRegistrationNumber); } }
        public Dog(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, SimpleDate lastWalkDate):base(chipRegistrationNumber, dateOfBirth, name)
        {   //null check nog doen
            LastWalkDate = lastWalkDate;
        }

        public override string ToString()
        {
            string lastWalkDate;
            if(LastWalkDate == null)
            {
                lastWalkDate = "Unknown";
            }
            else
            {
                lastWalkDate = LastWalkDate.ToString();
            }
            return "Dog: " + base.ToString() + ", " + lastWalkDate + ", " + Price; // Hoeft geen Price.ToString() dit is "redundant" dat houdt in dat de compiler al weet dat het hier om een string gaat
        }

        public decimal CalculatePrice(int chipRegistrationNumber)
        {
            if(ChipRegistrationNumber < 50000)
            {
                return 200;
            }
            else
            {
                return 350;
            }
        }
    }
}
