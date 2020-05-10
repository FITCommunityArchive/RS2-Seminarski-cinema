using Cinema.BLL;
using Cinema.Domain.Entities;
using NUnit.Framework;

namespace Cinema.Test.BLLTests
{
    public class SeatingServiceHelpersTests
    {

        [Test]
        [TestCase(1, 10, 10, "A1")]
        [TestCase(2, 10, 10, "A2")]
        [TestCase(10, 10, 10, "A10")]
        [TestCase(12, 10, 10, "B2")]
        [TestCase(100, 10, 10, "J10")]
        [TestCase(17, 10, 15, "B2")]
        [TestCase(30, 10, 15, "B15")]
        [TestCase(16, 15, 16, "A16")]
        [TestCase(17, 15, 16, "B1")]
        [TestCase(30, 15, 16, "B14")]
        [TestCase(31, 15, 16, "B15")]
        [TestCase(187, 15, 16, "L11")]
        [TestCase(240, 15, 16, "O16")]
        public void CreateSeatLabelTest_CorrectSeatNumber_ReturnsCorrectLabel(int seatNumber, int numberOfRows, int numberOfColumns, string expectedLabel)
        {
            Seat seat = CreateSeat(seatNumber, numberOfRows, numberOfColumns);

            seat.CreateSeatLabel();

            Assert.AreEqual(expectedLabel, seat.Label);
        }

        private Seat CreateSeat(int seatNumber, int numberOfRows, int numberOfColumns)
        {
            Hall hall = new Hall
            {
                NumberOfColumns = numberOfColumns,
                NumberOfRows = numberOfRows
            };

            return new Seat
            {
                Hall = hall,
                SeatNumber = seatNumber
            };
        }
    }
}
