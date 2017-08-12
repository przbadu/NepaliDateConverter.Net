using System;
namespace NepaliDateConverter
{
    public class Calendar : ICalendar
    {
        public Calendar() { }

        public string GetDayOfWeek(int index)
        {
            throw new NotImplementedException();
        }

        public string GetEnglishMonth(int index)
        {
            throw new NotImplementedException();
        }

        public string GetNepaliMonth(int index)
        {
            throw new NotImplementedException();
        }

        public bool IsLeapYear(int year)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }

            if (year % 4 == 0)
            {
                return true;
            }
            return false;
        }

        public bool ValidEnglishDate(int year, int month, int day)
        {
            throw new NotImplementedException();
        }

        public bool ValidNepaliDate(int year, int month, int day)
        {
            throw new NotImplementedException();
        }
    }
}
