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
    public class TimeHelperTests
    {
        [Test, Order(1)]
        [TestCase(0, 0, 0, 0, 0)]
        public void GetAllHalls(int additionalMonthsLimit, int additionalDaysLimit, int lowerHourOfDayLimit, int upperHourOfDayLimit, int additionalMinutesLimit)
        {
            DateTime dateTime = TimeHelper.GenerateFutureTime();
        }
    }
}
