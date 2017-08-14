namespace NepaliDateConverter.Net
{
    /// <summary>
    /// DateConverter class
    /// 
    /// DateConverter converter = new DateConverter();
    /// </summary>
    public class DateConverter : IDateConverter
    {
        /// <summary>
        /// Converts Given English Year, Month and Day into equivalent Nepali Date
        /// </summary>
        /// <param name="yy">2016</param>
        /// <param name="mm">4</param>
        /// <param name="dd">13</param>
        /// <returns>
        /// calendar.Year => 2073
        /// calendar.Month => 1
        /// calendar.Day => 1
        /// calendar.WeekDayName => Wednesday
        /// calendar.WeekDay => 4
        /// calendar.MonthName => Baishakh
        /// </returns>
        public Calendar ConvertToNepali(int yy, int mm, int dd)
        {
            Calendar calendar = new Calendar();

            if (calendar.ValidEnglishDate(yy, mm, dd))
            {
                // english months
                int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                // leap year months
                int[] lmonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                // initial values
                int def_eyy = 1944;
                int def_nyy = 2000;
                int def_nmm = 9;
                int def_ndd = 17 - 1;

                int day = 7 - 1;
                int total_eDays = 0;
                int total_nDays = 0;
                int a = 0;
                int m = 0;
                int y = 0;
                int i = 0;
                int j = 0;
                int numDay = 0;

                for (i = 0; i < yy - def_eyy; i++)
                {
                    if (calendar.IsLeapYear(def_eyy + i))
                    {
                        for (j = 0; j < 12; j++)
                        {
                            total_eDays += lmonth[j];
                        }
                    }
                    else
                    {
                        for (j = 0; j < 12; j++)
                        {
                            total_eDays += month[j];
                        }
                    }
                }

                // count total no. of days in terms of month
                for (i = 0; i < mm - 1; i++)
                {
                    if (calendar.IsLeapYear(yy))
                    {
                        total_eDays += lmonth[i];
                    }
                    else
                    {
                        total_eDays += month[i];
                    }
                }

                // count total no. of days in terms of day
                total_eDays += dd;
                i = 0;
                j = def_nmm;
                total_nDays = def_ndd;
                m = def_nmm;
                y = def_nyy;

                // count nepali date from calendar array
                while (total_eDays != 0)
                {
                    a = calendar.BSCalendar[i][j];
                    total_nDays++;
                    day++;
                    if (total_nDays > a)
                    {
                        m++; // increment month
                        total_nDays = 1; // reset nepali day to 1
                        j++; // index to next calendar's position
                    }

                    // reset day at the end of week passed
                    if (day > 7)
                        day = 1;

                    // reset month if end of month passed
                    // And increment year by 1
                    if (m > 12)
                    {
                        y++;
                        m = 1;
                    }

                    // reset index after last position of calender
                    // and increment i th position (meaning next year started)
                    if (j > 12)
                    {
                        j = 1;
                        i += 1;
                    }

                    total_eDays -= 1;
                }

                numDay = day;

                // public attribute accessors
                calendar.Year = y;
                calendar.Month = m;
                calendar.Day = total_nDays;
                calendar.WeekDay = day;
                calendar.WeekDayName = calendar.GetDayOfWeek(day);
                calendar.MonthName = calendar.GetNepaliMonth(m);

                return calendar;
            }
            else
            {
                return calendar;
            }
        }

        /// <summary>
        /// Returns English Date for given Nepali Year, Month and Day
        /// </summary>
        /// <param name="yy">2073</param>
        /// <param name="mm">1</param>
        /// <param name="dd">1</param>
        /// <returns>
        /// calendar.Year => 2016
        /// calendar.Month => 4
        /// calendar.Day => 13
        /// calendar.WeekDayName => Wednesday
        /// calendar.WeekDay => 4
        /// calendar.MonthName => April
        /// </returns>
        public Calendar ConvertToEnglish(int yy, int mm, int dd)
        {
            Calendar calendar = new Calendar();

            // Initial / Default values
            int def_eyy = 1943;
            int def_emm = 4;
            int def_edd = 14 - 1;

            // equivalent nepali date
            int def_nyy = 2000;

            int total_eDays = 0;
            int total_nDays = 0;
            int a = 0;
            int day = 4 - 1;
            int m = 0;
            int y = 0;
            int i = 0;
            int j = 0;
            int k = 0;

            int[] month = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] lmonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (calendar.ValidNepaliDate(yy, mm, dd))
            {
                // count total days in terms of year
                for (i = 0; i < yy - def_nyy; i++)
                {
                    for (j = 1; j <= 12; j++)
                    {
                        total_nDays += calendar.BSCalendar[k][j];
                    }
                    k++;
                }

                // count total days in terms of month
                for (j = 1; j < mm; j++)
                {
                    total_nDays += calendar.BSCalendar[k][j];
                }

                // count total days in terms of day
                total_nDays += dd;

                // calculation of equivalent english date
                total_eDays = def_edd;
                m = def_emm;
                y = def_eyy;

                while (total_nDays != 0)
                {
                    if (calendar.IsLeapYear(y))
                        a = lmonth[m];
                    else
                        a = month[m];

                    total_eDays++;
                    day++;

                    if (total_eDays > a)
                    {
                        m++;
                        total_eDays = 1;

                        if (m > 12)
                        {
                            y++;
                            m = 1;
                        }
                    }

                    if (day > 7)
                        day = 1;

                    total_nDays--;
                }

                // public attribute accessors
                calendar.Year = y;
                calendar.Month = m;
                calendar.Day = total_eDays;
                calendar.WeekDay = day;
                calendar.WeekDayName = calendar.GetDayOfWeek(day);
                calendar.MonthName = calendar.GetEnglishMonth(m);

                return calendar;
            }
            else
            {
                return calendar;
            }
        }
    }
}
