using Microsoft.Extensions.Configuration;
using Moq;
using NUnit.Framework;


namespace Cinema.Test.DALTests
{
    [TestFixture]
    public class ReservationsControllerTest : TestBase
    {
        private readonly Mock<IConfiguration> _configuration;

        public ReservationsControllerTest()
        {
            _configuration = new Mock<IConfiguration>();
        }
    }
}
