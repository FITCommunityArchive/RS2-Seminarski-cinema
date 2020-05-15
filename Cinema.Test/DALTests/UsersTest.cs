using NUnit.Framework;
using System.Linq;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    class UsersTest : TestBase
    {
        [Test, Order(1)]
        public void GetUsers()
        {
            int usersCount = unit.Users.Get().Count();

            //Act

            //Assert
            //There are 10 users in the test database
            Assert.AreEqual(10, usersCount);
        }
    }
}
