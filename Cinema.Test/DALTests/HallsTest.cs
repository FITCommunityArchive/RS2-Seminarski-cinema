using Cinema.Domain.Entities;
using Cinema.Web.Pages.Halles;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    public class HallsTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllHalls()
        {
            DbSet<Hall> halls = context.Halls;
  
            //There are 2 halls in the test database
            Assert.AreEqual(2, halls.CountAsync());
        }

        [Test, Order(1)]
        [TestCase(2)]
        public async Task GetHallById(int id)
        {
            //Try to get Hall with id nr. 2 through IndexModel
            Hall hall = await context.Halls.FirstOrDefaultAsync(x => x.Id == id);       

            Assert.AreEqual("Movie Hall 2", hall.Name);            
        }
    }
}
