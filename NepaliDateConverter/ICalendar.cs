using System;
namespace NepaliDateConverter
{
    public interface ICalendar
    {
        /// <summary>
        /// Getter and Setter for Year
        /// </summary>
        /// <value>2017</value>
        int Year { get; set; }

        /// <summary>
        /// Getter and setter for Month
        /// </summary>
        /// <value>11</value>
        int Month { get; set; }

        /// <summary>
        /// Getter and setter for Day
        /// </summary>
        /// <value>32</value>
        int Day { get; set; }

        /// <summary>
        /// Getter and setter for week day name
        /// </summary>
        /// <value>Sunday</value>
        string WeekDayName { get; }

        /// <summary>
        /// Getter and setter for Month name
        /// </summary>
        /// <value>January/Baishakh</value>
        string MonthName { get; }

        /// <summary>
        /// Getter and setter for Week Day
        /// </summary>
        /// <value>1</value>
        int WeekDay { get; set; }

        /// <summary>
        /// Returns week days; Sunday, Monday, ... , Saturday. 
        /// It expects index range from 1 through 7
        /// </summary>
        /// <param name="day">1</param>
        string GetDayOfWeek(int day);

        /// <summary>
        /// This function returns English Months like January, February,..,December.
        /// It expects index range from 1 through 12
        /// </summary>
        /// <param name="month">1</param>
        string GetEnglishMonth(int month);

        /// <summary>
        /// This function returns Nepali Months like Baishakh, Jesth,..,Chaitra.
        /// It expects index range from 1 through 12
        /// </summary>
        /// <param name="month">12</param>
        string GetNepaliMonth(int month);

        /// <summary>
        /// Will check if given year, month and day are in valid english date range
        /// and return either true/false.
        /// Valid Date ranges are 1994 through 2033
        /// </summary>
        /// <returns><c>true</c>, if english date was valided, <c>false</c> otherwise.</returns>
        /// <param name="year">2017</param>
        /// <param name="month">01</param>
        /// <param name="day">20</param>
        bool ValidEnglishDate(int year, int month, int day);

        /// <summary>
        /// Will check if given year, month and day are in valid nepali date range
        /// and returns either true/false.
        /// Valid Date ranges are 2000 through 2089
        /// </summary>
        /// <returns><c>true</c>, if nepali date was valided, <c>false</c> otherwise.</returns>
        /// <param name="year">2074</param>
        /// <param name="month">12</param>
        /// <param name="day">01</param>
        bool ValidNepaliDate(int year, int month, int day);

        /// <summary>
        /// Check if given year is leap year or not and returns either true/false.
        /// </summary>
        /// <returns><c>true</c>, if leap year was ised, <c>false</c> otherwise.</returns>
        /// <param name="year">2016</param>
        bool IsLeapYear(int year);
    }
}
