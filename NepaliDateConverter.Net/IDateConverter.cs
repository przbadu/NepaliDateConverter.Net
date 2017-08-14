namespace NepaliDateConverter.Net
{
    /// <summary>
    /// Summary
    /// </summary>
    interface IDateConverter
    {
        /// <summary>
        /// Getter and Setter for Year
        /// </summary>
        /// <value>2017</value>
        int Year { get; }

        /// <summary>
        /// Getter and setter for Month
        /// </summary>
        /// <value>11</value>
        int Month { get; }

        /// <summary>
        /// Getter and setter for Day
        /// </summary>
        /// <value>32</value>
        int Day { get; }

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
        int WeekDay { get; }

        /// <summary>
        /// Will convert given English Date to Nepali Date
        /// </summary>
        /// <returns>Nepali Date</returns>
        /// <param name="yy">2017</param>
        /// <param name="mm">12</param>
        /// <param name="dd">3</param>
        //DateConverter ConvertToNepali(int yy, int mm, int dd);

        /// <summary>
        /// Will convert given Nepali Date to English Date
        /// </summary>
        /// <returns>English Date</returns>
        /// <param name="yy">2074</param>
        /// <param name="mm">12</param>
        /// <param name="dd">1</param>
        //DateConverter ConvertToEnglish(int yy, int mm, int dd);
    }
}
