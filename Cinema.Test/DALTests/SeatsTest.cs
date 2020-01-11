using Cinema.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    class SeatsTest : TestBase
    {
        [Test, Order(1)]
        [TestCase(20)]
        public void GetSeatLabel(int id)
        {
            Seat seat = unit.Seats.Get(id);
            Assert.AreEqual("A5", seat.Label);
        }
    }
}
