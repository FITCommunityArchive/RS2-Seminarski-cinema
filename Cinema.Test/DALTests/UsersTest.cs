using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    class UsersTest : TestBase
    {
        [Test, Order(1)]
        public void GetUsers()
        {
            DbSet<ApplicationUser> users = context.Users;

            //Act

            //Assert
            //There are 10 users in the test database
            Assert.AreEqual(10, users.Count());
        }
    }
}
