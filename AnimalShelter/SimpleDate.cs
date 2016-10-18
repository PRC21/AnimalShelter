using System;

namespace AnimalShelter
{
    public class SimpleDate
    {
        private DateTime date;
        public SimpleDate(int day, int month, int Year)
        {
            if(date < DateTime.Today)
            {
                date = new DateTime(Year, month, day);
            }
        }
        public int Day
        {
            get { return date.Day; }
        }
        public int Month
        {
            get { return date.Month; }
        }
        public int Year
        {
            get { return date.Year; }
        }
        public int DaysDifference(SimpleDate dateDifference) 
        {
            TimeSpan timespan = dateDifference.date.Subtract(this.date);
            return timespan.Days;
        }
        public override string ToString()
        {
            return date.ToString("dd-MM-yyyy");
        }
    }
}
