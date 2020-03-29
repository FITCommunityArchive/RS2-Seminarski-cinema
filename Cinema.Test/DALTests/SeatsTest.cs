using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Seed.CollectMethods;
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
    class SeatsTest : TestBase
    {
        [Test, Order(1)]
        [TestCase(1, 20, "B4")]
        [TestCase(2, 224, "N16")]
        [TestCase(2, 240, "O16")]
        public async Task GetSeatLabel(int hallId, int seatNumber, string seatLabel)
        {
            Seat seat = (await unit.Halls.GetAsync(hallId)).Seats.Where(x => x.SeatNumber == seatNumber).Single();

            Assert.AreEqual(seatLabel, seat.Label);
        }
    }
}
