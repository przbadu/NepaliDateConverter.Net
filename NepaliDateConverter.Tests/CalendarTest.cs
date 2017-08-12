using NUnit.Framework;
using System;
namespace NepaliDateConverter.Tests
{
    [TestFixture()]
    public class CalendarTest
    {
        Calendar calendar;

        [SetUp()]
        public void Init()
        {
            calendar = new Calendar();
        }

        [TearDown()]
        public void Dispose()
        {
            calendar = null;
        }

        [Test()]
        public void YearPropsTest()
        {
            calendar.Year = 2078;
            Assert.AreEqual(2078, calendar.Year);
        }

        [Test]
        public void MonthPropsTest()
        {
            calendar.Month = 2;
            Assert.AreEqual(2, calendar.Month);
        }

        [Test]
        public void DayPropsTest()
        {
            calendar.Day = 2;
            Assert.AreEqual(2, calendar.Day);
        }

        [Test]
        public void WeekDayNamePropsTest()
        {
            calendar.WeekDayName = "Sunday";
            Assert.AreEqual("Sunday", calendar.WeekDayName);
        }

        [Test]
        public void MonthNamePropsTest()
        {
            calendar.MonthName = "January";
            Assert.AreEqual("January", calendar.MonthName);
        }

        [Test]
        public void WeekDayPropsTest()
        {
            calendar.WeekDay = 1;
            Assert.AreEqual(1, calendar.WeekDay);
        }

        // IsLeapYear()
        [Test()]
        public void TestIsLeapYearShouldReturnTrue()
        {
            Assert.IsTrue(calendar.IsLeapYear(1904));
            Assert.IsTrue(calendar.IsLeapYear(1908));
            Assert.IsTrue(calendar.IsLeapYear(1912));
            Assert.IsTrue(calendar.IsLeapYear(1916));
            Assert.IsTrue(calendar.IsLeapYear(2000));
            Assert.IsTrue(calendar.IsLeapYear(2004));
            Assert.IsTrue(calendar.IsLeapYear(2008));
            Assert.IsTrue(calendar.IsLeapYear(2012));
            Assert.IsTrue(calendar.IsLeapYear(2016));
            Assert.IsTrue(calendar.IsLeapYear(2020));
        }

        [Test]
        public void TestIsLeapYearShouldReturnFalse()
        {
            bool isLeapYear2017 = calendar.IsLeapYear(2017);
            bool isLeapYear2018 = calendar.IsLeapYear(2018);
            bool isLeapYear2025 = calendar.IsLeapYear(2025);
            Assert.IsFalse(isLeapYear2017);
            Assert.IsFalse(isLeapYear2018);
            Assert.IsFalse(isLeapYear2025);
        }

        // GetDayOfWeek()
        [Test]
        public void TestGetDayOfWeekShouldReturnDayOfWeek()
        {
            Assert.AreEqual("Sunday", calendar.GetDayOfWeek(0));
            Assert.AreEqual("Sunday", calendar.GetDayOfWeek(1));
            Assert.AreEqual("Monday", calendar.GetDayOfWeek(2));
            Assert.AreEqual("Tuesday", calendar.GetDayOfWeek(3));
            Assert.AreEqual("Wednesday", calendar.GetDayOfWeek(4));
            Assert.AreEqual("Thursday", calendar.GetDayOfWeek(5));
            Assert.AreEqual("Friday", calendar.GetDayOfWeek(6));
            Assert.AreEqual("Saturday", calendar.GetDayOfWeek(7));
        }

        // GetEnglishMonth()
        [Test]
        public void TestGetEnglishMonthShouldReturnEnglishMonthName()
        {
            Assert.AreEqual("January", calendar.GetEnglishMonth(0));
            Assert.AreEqual("January", calendar.GetEnglishMonth(1));
            Assert.AreEqual("February", calendar.GetEnglishMonth(2));
            Assert.AreEqual("March", calendar.GetEnglishMonth(3));
            Assert.AreEqual("April", calendar.GetEnglishMonth(4));
            Assert.AreEqual("May", calendar.GetEnglishMonth(5));
            Assert.AreEqual("June", calendar.GetEnglishMonth(6));
            Assert.AreEqual("July", calendar.GetEnglishMonth(7));
            Assert.AreEqual("August", calendar.GetEnglishMonth(8));
            Assert.AreEqual("September", calendar.GetEnglishMonth(9));
            Assert.AreEqual("October", calendar.GetEnglishMonth(10));
            Assert.AreEqual("November", calendar.GetEnglishMonth(11));
            Assert.AreEqual("December", calendar.GetEnglishMonth(12));
        }

        // GetNepaliMonth()
        [Test]
        public void TestGetNepaliMonthShouldReturnNepaliMonthName()
        {
            Assert.AreEqual("Baishakh", calendar.GetNepaliMonth(0));
            Assert.AreEqual("Baishakh", calendar.GetNepaliMonth(1));
            Assert.AreEqual("Jestha", calendar.GetNepaliMonth(2));
            Assert.AreEqual("Ashad", calendar.GetNepaliMonth(3));
            Assert.AreEqual("Shrawan", calendar.GetNepaliMonth(4));
            Assert.AreEqual("Bhadra", calendar.GetNepaliMonth(5));
            Assert.AreEqual("Aswin", calendar.GetNepaliMonth(6));
            Assert.AreEqual("Kartik", calendar.GetNepaliMonth(7));
            Assert.AreSame("Mangshir", calendar.GetNepaliMonth(8));
            Assert.AreEqual("Poush", calendar.GetNepaliMonth(9));
            Assert.AreEqual("Magh", calendar.GetNepaliMonth(10));
            Assert.AreEqual("Falgun", calendar.GetNepaliMonth(11));
            Assert.AreEqual("Chaitra", calendar.GetNepaliMonth(12));
        }

        // ValidEnglishDate()
        [Test]
        public void TestValidEnglishDateShouldReturnTrue()
        {
            // Valid years
            for (int year = 1944; year <= 2033; year++)
            {
                Assert.IsTrue(calendar.ValidEnglishDate(year, 1, 1));
            }

            // valid months
            for (int month = 1; month <= 12; month++)
            {
                Assert.IsTrue(calendar.ValidEnglishDate(2017, month, 1));
            }

            // valid days
            for (int day = 1; day <= 31; day++)
            {
                Assert.IsTrue(calendar.ValidEnglishDate(2017, 8, day));
            }
        }

        [Test]
        public void TestValidEnglishDateShouldBeInvalid()
        {
            Assert.IsFalse(calendar.ValidEnglishDate(1943, 1, 1));
            Assert.IsFalse(calendar.ValidEnglishDate(2017, 13, 1));
            Assert.IsFalse(calendar.ValidEnglishDate(1943, 11, 33));
            Assert.IsFalse(calendar.ValidEnglishDate(2034, 1, 1));
        }

        // ValidNepaliDate()
        [Test]
        public void TestValidNepaliDateShouldReturnTrue()
        {
            // Valid years
            for (int year = 2000; year <= 2089; year++)
            {
                Assert.IsTrue(calendar.ValidNepaliDate(year, 1, 1));
            }

            // valid months
            for (int month = 1; month <= 12; month++)
            {
                Assert.IsTrue(calendar.ValidNepaliDate(2074, month, 1));
            }

            // valid days
            for (int day = 1; day <= 32; day++)
            {
                Assert.IsTrue(calendar.ValidNepaliDate(2074, 8, day));
            }
        }

        [Test]
        public void TestValidNepaliDateShouldBeInvalid()
        {
            Assert.IsFalse(calendar.ValidNepaliDate(1999, 1, 1));
            Assert.IsFalse(calendar.ValidNepaliDate(2090, 1, 1));
            Assert.IsFalse(calendar.ValidNepaliDate(2074, 1, 33));
            Assert.IsFalse(calendar.ValidNepaliDate(2090, 13, 1));
        }
    }
}
