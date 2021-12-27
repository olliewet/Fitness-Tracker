using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackHealthAndFitness.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace TrackHealthAndFitness.Helpers.Tests
{
    [TestClass()]
    public class DateHelperTests
    {
        [TestMethod()]
        public void intToDayParsing()
        {
            DayOfWeek date = DateHelper.intToDay(1);
            DayOfWeek expectedDate = DayOfWeek.Monday;
            Assert.AreEqual(date, expectedDate);
        }

        [TestMethod()]
        public void removeDateTime()
        {
            string testResult = DateHelper.RemoveTime("12/01/2021 00:00:00");
            string expectedResult = "12/01/2021";
            Assert.AreEqual(expectedResult, testResult);
        }

    }
}