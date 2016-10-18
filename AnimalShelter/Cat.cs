
using System;

namespace AnimalShelter
{
    [Serializable]
    public class Cat : Animal
    {
        public string BadHabits { get; set; }
        public override decimal Price { get { return CalculatePrice(BadHabits); } }

        public Cat(int chipRegistrationNumber, SimpleDate dateOfBirth,
                   string name, string badHabits) :base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
        }
        public override string ToString()
        {
            string badHabits;
            if(BadHabits == "")
            {
                badHabits = "none";
            }
            else
            {
                badHabits = BadHabits;
            }
            return "Cat: " + base.ToString() + ", " + badHabits + ", " + Price;
        }

        public decimal CalculatePrice(string badHabits)
        {
            decimal price = 60;
            if(badHabits == "")
            {
                return 60;
            }
            else if(price - badHabits.Trim().Length > 20)
            {
                price -= badHabits.Trim().Length;
                return price;
            }
            else
            {
                return 20;
            }

        }
    }
}
