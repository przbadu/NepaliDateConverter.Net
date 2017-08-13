using System;
namespace NepaliDateConverter
{
    public interface INepaliDateConverter
    {
        /// <summary>
        /// Will convert given English Date to Nepali Date
        /// </summary>
        /// <returns>The to nepali.</returns>
        /// <param name="year">2017</param>
        /// <param name="month">12</param>
        /// <param name="day">3</param>
        Calendar ConvertToNepali(int year, int month, int day);

        /// <summary>
        /// Will convert given Nepali Date to English Date
        /// </summary>
        /// <returns>The to english.</returns>
        /// <param name="year">2074</param>
        /// <param name="month">12</param>
        /// <param name="day">1</param>
        Calendar ConvertToEnglish(int year, int month, int day);
    }
}
