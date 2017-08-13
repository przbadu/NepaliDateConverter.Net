using System;
namespace NepaliDateConverter
{
    public class NepaliDateConverter : INepaliDateConverter
    {
        public Calendar calendar;

        public Calendar ConvertToNepali(int yy, int mm, int dd)
        {
            if (calendar.ValidNepaliDate(yy, mm, dd))
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

                for (int k = 0; k < yy - def_eyy; k++)
                {
                    if (calendar.IsLeapYear(def_eyy + k))
                    {
                        for (int l = 0; l < 12; l++)
                        {
                            total_eDays += lmonth[l];
                        }
                    }
                    else
                    {
                        for (int l = 0; l < 12; l++)
                        {
                            total_eDays += month[l];
                        }
                    }
                }

                // count total no. of days in terms of month
                for (int k = 0; k < mm - 1; k++)
                {
                    if (calendar.IsLeapYear(yy))
                    {
                        total_eDays += lmonth[k];
                    }
                    else
                    {
                        total_eDays += month[k];
                    }
                }

                // count total no. of days in terms of day
                total_eDays += dd;
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
                    if (total_nDays > day)
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
                return null;
            }
        }

        public Calendar ConvertToEnglish(int year, int month, int day)
        {
            throw new NotImplementedException();
        }
    }
}
