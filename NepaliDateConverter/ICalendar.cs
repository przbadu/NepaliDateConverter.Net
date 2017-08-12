using System;
namespace NepaliDateConverter
{
    public interface ICalendar
    {
		/// <summary>
        /// Returns week days; Sunday, Monday, ... , Saturday. 
        /// It expects index range from 1 through 7
		/// </summary>
		/// <param name="index">Index.</param>
		string GetDayOfWeek(int index);

        /// <summary>
        /// This function returns English Months like January, February,..,December.
        /// It expects index range from 1 through 12
        /// </summary>
        /// <param name="index">Index.</param>
        string GetEnglishMonth(int index);

		/// <summary>
		/// This function returns Nepali Months like Baishakh, Jesth,..,Chaitra.
		/// It expects index range from 1 through 12
		/// </summary>
		/// <param name="index">Index.</param>
		string GetNepaliMonth(int index);

        /// <summary>
        /// Will check if given year, month and day are in valid english date range
        /// and return either true/false.
        /// Valid Date ranges are 1994 through 2033
        /// </summary>
        /// <returns><c>true</c>, if english date was valided, <c>false</c> otherwise.</returns>
        /// <param name="year">Year.</param>
        /// <param name="month">Month.</param>
        /// <param name="day">Day.</param>
        bool ValidEnglishDate(int year, int month, int day);

        /// <summary>
        /// Will check if given year, month and day are in valid nepali date range
        /// and returns either true/false.
        /// Valid Date ranges are 2000 through 2089
        /// </summary>
        /// <returns><c>true</c>, if nepali date was valided, <c>false</c> otherwise.</returns>
        /// <param name="year">Year.</param>
        /// <param name="month">Month.</param>
        /// <param name="day">Day.</param>
        bool ValidNepaliDate(int year, int month, int day);

        /// <summary>
        /// Check if given year is leap year or not and returns either true/false.
        /// </summary>
        /// <returns><c>true</c>, if leap year was ised, <c>false</c> otherwise.</returns>
        /// <param name="year">Year.</param>
        bool IsLeapYear(int year);
    }
}
