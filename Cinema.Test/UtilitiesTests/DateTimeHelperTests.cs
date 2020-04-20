using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Seed.CollectMethods;
using Cinema.Services.Exceptions;
using Cinema.Services.Helpers;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        [Test, Order(1)]
        [TestCase(2020, 4, 20, 21, 30, 20, "20.04.2020")]
        public void ToFormattedDate(int year, int month, int day, int hours, int minutes, int seconds, string expectedResult)
        {
            DateTime dateTime = new DateTime(year, month, day, hours, minutes, seconds);
            string result = dateTime.ToFormattedDate();
            Assert.AreEqual(expectedResult, result);
        }

        [Test, Order(1)]
        [TestCase(2020, 4, 20, 21, 30, 20, "21:30")]
        public void ToFormattedTime(int year, int month, int day, int hours, int minutes, int seconds, string expectedResult)
        {
            DateTime dateTime = new DateTime(year, month, day, hours, minutes, seconds);
            string result = dateTime.ToFormattedTime();
            Assert.AreEqual(expectedResult, result);
        }

    }
}
