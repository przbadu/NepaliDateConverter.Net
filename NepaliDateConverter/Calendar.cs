using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace NepaliDateConverter
{
    public class Calendar : ICalendar
    {
        private IDictionary<int, string> WeekNames;
        private IDictionary<int, string> EnglishMonthNames;
        private IDictionary<int, string> NepaliMonthNames;
        private IDictionary<int, int[]> BSCalendar;

        public Calendar()
        {
            SetWeekNames();
            SetEnglishMonthNames();
            SetNepaliMonthNames();
            SetBSCalendar();
        }

        public string GetDayOfWeek(int day)
        {
            if (day < 1 || day > 7)
                day = 1;
            return WeekNames[day];
        }

        public string GetEnglishMonth(int month)
        {
            if (month < 1 || month > 12)
                month = 1;
            return EnglishMonthNames[month];
        }

        public string GetNepaliMonth(int month)
        {
            if (month < 1 || month > 12)
                month = 1;
            return NepaliMonthNames[month];
        }

        public bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        public bool ValidEnglishDate(int year, int month, int day)
        {
            if (year < 1944 || year > 2033)
            {
                Debug.WriteLine("Year should be between 1944 - 2033");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Debug.WriteLine("Month should be between 1 - 12");
                return false;
            }

            if (day < 1 || day > 31)
            {
                Debug.WriteLine("Day should be between 1 - 31");
                return false;
            }

            return true;
        }

        public bool ValidNepaliDate(int year, int month, int day)
        {
            if (year < 2000 || year > 2089)
            {
                Debug.WriteLine("Year should be between 1944 - 2033");
                return false;
            }

            if (month < 1 || month > 12)
            {
                Debug.WriteLine("Month should be between 1 - 12");
                return false;
            }

            if (day < 1 || day > 32)
            {
                Debug.WriteLine("Day should be between 1 - 31");
                return false;
            }

            return true;
        }

        private void SetWeekNames()
        {
            WeekNames = new Dictionary<int, string>();
            WeekNames.Add(1, "Sunday");
            WeekNames.Add(2, "Monday");
            WeekNames.Add(3, "Tuesday");
            WeekNames.Add(4, "Wednesday");
            WeekNames.Add(5, "Thursday");
            WeekNames.Add(6, "Friday");
            WeekNames.Add(7, "Saturday");
        }

        private void SetEnglishMonthNames()
        {
            EnglishMonthNames = new Dictionary<int, string>();
            EnglishMonthNames.Add(1, "January");
            EnglishMonthNames.Add(2, "February");
            EnglishMonthNames.Add(3, "March");
            EnglishMonthNames.Add(4, "April");
            EnglishMonthNames.Add(5, "May");
            EnglishMonthNames.Add(6, "June");
            EnglishMonthNames.Add(7, "July");
            EnglishMonthNames.Add(8, "August");
            EnglishMonthNames.Add(9, "September");
            EnglishMonthNames.Add(10, "October");
            EnglishMonthNames.Add(11, "November");
            EnglishMonthNames.Add(12, "December");
        }

        private void SetNepaliMonthNames()
        {
            NepaliMonthNames = new Dictionary<int, string>();
            NepaliMonthNames.Add(1, "Baishakh");
            NepaliMonthNames.Add(2, "Jestha");
            NepaliMonthNames.Add(3, "Ashad");
            NepaliMonthNames.Add(4, "Shrawan");
            NepaliMonthNames.Add(5, "Bhadra");
            NepaliMonthNames.Add(6, "Aswin");
            NepaliMonthNames.Add(7, "Kartik");
            NepaliMonthNames.Add(8, "Mangshir");
            NepaliMonthNames.Add(9, "Poush");
            NepaliMonthNames.Add(10, "Magh");
            NepaliMonthNames.Add(11, "Falgun");
            NepaliMonthNames.Add(12, "Chaitra");
        }

        private void SetBSCalendar()
        {
            BSCalendar = new Dictionary<int, int[]>();
            BSCalendar.Add(0, new int[] { 2000, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(1, new int[] { 2001, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(2, new int[] { 2002, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(3, new int[] { 2003, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(4, new int[] { 2004, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(5, new int[] { 2005, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(6, new int[] { 2006, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(7, new int[] { 2007, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(8, new int[] { 2008, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });
            BSCalendar.Add(9, new int[] { 2009, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(10, new int[] { 2010, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(11, new int[] { 2011, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(12, new int[] { 2012, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            BSCalendar.Add(13, new int[] { 2013, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(14, new int[] { 2014, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(15, new int[] { 2015, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(16, new int[] { 2016, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            BSCalendar.Add(17, new int[] { 2017, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(18, new int[] { 2018, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(19, new int[] { 2019, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(20, new int[] { 2020, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(21, new int[] { 2021, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(22, new int[] { 2022, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            BSCalendar.Add(23, new int[] { 2023, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(24, new int[] { 2024, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(25, new int[] { 2025, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(26, new int[] { 2026, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(27, new int[] { 2027, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(28, new int[] { 2028, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(29, new int[] { 2029, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(30, new int[] { 2030, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(31, new int[] { 2031, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(32, new int[] { 2032, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(33, new int[] { 2033, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(34, new int[] { 2034, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(35, new int[] { 2035, 30, 32, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });
            BSCalendar.Add(36, new int[] { 2036, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(37, new int[] { 2037, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(38, new int[] { 2038, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(39, new int[] { 2039, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            BSCalendar.Add(40, new int[] { 2040, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(41, new int[] { 2041, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(42, new int[] { 2042, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(43, new int[] { 2043, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            BSCalendar.Add(44, new int[] { 2044, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(45, new int[] { 2045, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(46, new int[] { 2046, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(47, new int[] { 2047, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(48, new int[] { 2048, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(49, new int[] { 2049, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            BSCalendar.Add(50, new int[] { 2050, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(51, new int[] { 2051, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(52, new int[] { 2052, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(53, new int[] { 2053, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            BSCalendar.Add(54, new int[] { 2054, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(55, new int[] { 2055, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(56, new int[] { 2056, 31, 31, 32, 31, 32, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(57, new int[] { 2057, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(58, new int[] { 2058, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(59, new int[] { 2059, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(60, new int[] { 2060, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(61, new int[] { 2061, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(62, new int[] { 2062, 30, 32, 31, 32, 31, 31, 29, 30, 29, 30, 29, 31 });
            BSCalendar.Add(63, new int[] { 2063, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(64, new int[] { 2064, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(65, new int[] { 2065, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(66, new int[] { 2066, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 29, 31 });
            BSCalendar.Add(67, new int[] { 2067, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(68, new int[] { 2068, 31, 31, 32, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(69, new int[] { 2069, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(70, new int[] { 2070, 31, 31, 31, 32, 31, 31, 29, 30, 30, 29, 30, 30 });
            BSCalendar.Add(71, new int[] { 2071, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(72, new int[] { 2072, 31, 32, 31, 32, 31, 30, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(73, new int[] { 2073, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 31 });
            BSCalendar.Add(74, new int[] { 2074, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(75, new int[] { 2075, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(76, new int[] { 2076, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            BSCalendar.Add(77, new int[] { 2077, 31, 32, 31, 32, 31, 30, 30, 30, 29, 30, 29, 31 });
            BSCalendar.Add(78, new int[] { 2078, 31, 31, 31, 32, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(79, new int[] { 2079, 31, 31, 32, 31, 31, 31, 30, 29, 30, 29, 30, 30 });
            BSCalendar.Add(80, new int[] { 2080, 31, 32, 31, 32, 31, 30, 30, 30, 29, 29, 30, 30 });
            BSCalendar.Add(81, new int[] { 2081, 31, 31, 32, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(82, new int[] { 2082, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(83, new int[] { 2083, 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(84, new int[] { 2084, 31, 31, 32, 31, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(85, new int[] { 2085, 31, 32, 31, 32, 30, 31, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(86, new int[] { 2086, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(87, new int[] { 2087, 31, 31, 32, 31, 31, 31, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(88, new int[] { 2088, 30, 31, 32, 32, 30, 31, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(89, new int[] { 2089, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
            BSCalendar.Add(90, new int[] { 2090, 30, 32, 31, 32, 31, 30, 30, 30, 29, 30, 30, 30 });
        }
    }
}
