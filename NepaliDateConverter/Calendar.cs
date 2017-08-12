using System;
namespace NepaliDateConverter
{
    public class Calendar : ICalendar
    {
        public string GetDayOfWeek(int day)
        {
            throw new NotImplementedException();
        }

        public string GetEnglishMonth(int month)
        {
            throw new NotImplementedException();
        }

        public string GetNepaliMonth(int month)
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
