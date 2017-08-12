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
        public void TestGetDayOfWeekShouldReturnDefaultValue()
        {
            Assert.AreEqual("", calendar.GetDayOfWeek(9));
        }

        public void TestGetDayOfWeekShouldReturnSunday()
        {
            Assert.AreEqual("Sunday", calendar.GetDayOfWeek(1));
        }

        public void TestGetDayOfWeekShouldReturnMonday()
        {
            Assert.AreEqual("Monday", calendar.GetDayOfWeek(2));
        }

        public void TestGetDayOfWeekShouldReturnTuesday()
        {
            Assert.AreEqual("Tuesday", calendar.GetDayOfWeek(2));
        }

        public void TestGetDayOfWeekShouldReturnWednesday()
        {
            Assert.AreEqual("Wednesday", calendar.GetDayOfWeek(4));
        }

        public void TestGetDayOfWeekshouldReturnThursday()
        {
            Assert.AreEqual("Thursday", calendar.GetDayOfWeek(5));
        }

        public void TestGetDayOfWeekShouldReturnFriday()
        {
            Assert.AreEqual("Friday", calendar.GetDayOfWeek(7));
        }

        public void TestGetDayOfWeekShouldReturnSaturday()
        {
            Assert.AreEqual("Saturday", calendar.GetDayOfWeek(7));
        }
    }
}
