using NUnit.Framework;
using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace NepaliDateConverter.Tests
{
    [TestFixture()]
    public class NepaliDateConverterTest
    {
        NepaliDateConverter converter;
        Calendar calendar;

        [SetUp]
        public void Init()
        {
            converter = new NepaliDateConverter();
        }

        [TearDown]
        public void Dispose()
        {
            converter = null;
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_13()
        {
            calendar = converter.ConvertToEnglish(2073, 1, 1);
            Assert.AreEqual(2016, calendar.Year);
            Assert.AreEqual(4, calendar.Month, null, "Month doesn't matched");
            Assert.AreEqual(13, calendar.Day);
            Assert.AreEqual("Wednesday", calendar.WeekDayName);
            Assert.AreEqual("April", calendar.MonthName);
            Assert.AreEqual(4, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_1()
        {
            calendar = converter.ConvertToNepali(2016, 4, 13);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(1, calendar.Day);
            Assert.AreEqual("Wednesday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(4, calendar.WeekDay);
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_14()
        {
            calendar = converter.ConvertToEnglish(2073, 1, 2);
            Assert.AreEqual(2016, calendar.Year);
            Assert.AreEqual(4, calendar.Month);
            Assert.AreEqual(14, calendar.Day);
            Assert.AreEqual("Thursday", calendar.WeekDayName);
            Assert.AreEqual("April", calendar.MonthName);
            Assert.AreEqual(5, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_2()
        {
            calendar = converter.ConvertToNepali(2016, 4, 14);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(2, calendar.Day);
            Assert.AreEqual("Thursday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(5, calendar.WeekDay);
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_4_27()
        {
            calendar = converter.ConvertToEnglish(2073, 1, 15);
            Assert.AreEqual(2016, calendar.Year);
            Assert.AreEqual(4, calendar.Month);
            Assert.AreEqual(27, calendar.Day);
            Assert.AreEqual("Wednesday", calendar.WeekDayName);
            Assert.AreEqual("April", calendar.MonthName);
            Assert.AreEqual(4, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_15()
        {
            calendar = converter.ConvertToNepali(2016, 4, 27);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(15, calendar.Day);
            Assert.AreEqual("Wednesday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(4, calendar.WeekDay);
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_5_12()
        {
            calendar = converter.ConvertToEnglish(2073, 1, 30);
            Assert.AreEqual(2016, calendar.Year);
            Assert.AreEqual(5, calendar.Month);
            Assert.AreEqual(12, calendar.Day);
            Assert.AreEqual("Thursday", calendar.WeekDayName);
            Assert.AreEqual("May", calendar.MonthName);
            Assert.AreEqual(5, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_30()
        {
            calendar = converter.ConvertToNepali(2016, 5, 12);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(30, calendar.Day);
            Assert.AreEqual("Thursday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(5, calendar.WeekDay);
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2016_5_13()
        {
            calendar = converter.ConvertToEnglish(2073, 1, 31);
            Assert.AreEqual(2016, calendar.Year);
            Assert.AreEqual(5, calendar.Month);
            Assert.AreEqual(13, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("May", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_1_31()
        {
            calendar = converter.ConvertToNepali(2016, 5, 13);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(31, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }



        [Test()]
        public void ConvertToEnglishShouldReturn2017_1_6()
        {
            calendar = converter.ConvertToEnglish(2073, 9, 22);
            Assert.AreEqual(2017, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(6, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("January", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2073_9_22()
        {
            calendar = converter.ConvertToNepali(2017, 1, 6);
            Assert.AreEqual(2073, calendar.Year);
            Assert.AreEqual(9, calendar.Month);
            Assert.AreEqual(22, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("Poush", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test()]
        public void ConvertToEnglishShouldReturn2017_4_14()
        {
            calendar = converter.ConvertToEnglish(2074, 1, 1);
            Assert.AreEqual(2017, calendar.Year);
            Assert.AreEqual(4, calendar.Month);
            Assert.AreEqual(14, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("April", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2074_1_1()
        {
            calendar = converter.ConvertToNepali(2017, 4, 14);
            Assert.AreEqual(2074, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(1, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test]
        public void ConvertToEnglishShouldReturn2017_4_28()
        {
            calendar = converter.ConvertToEnglish(2074, 1, 15);
            Assert.AreEqual(2017, calendar.Year);
            Assert.AreEqual(4, calendar.Month);
            Assert.AreEqual(28, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("April", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }

        [Test]
        public void ConvertToNepaliShouldReturn2074_1_15()
        {
            calendar = converter.ConvertToNepali(2017, 4, 28);
            Assert.AreEqual(2074, calendar.Year);
            Assert.AreEqual(1, calendar.Month);
            Assert.AreEqual(15, calendar.Day);
            Assert.AreEqual("Friday", calendar.WeekDayName);
            Assert.AreEqual("Baishakh", calendar.MonthName);
            Assert.AreEqual(6, calendar.WeekDay);
        }
    }
}
