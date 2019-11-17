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
        public async Task GetAllHalls()
        {
            //Arrange
            DbSet<Hall> halls = context.Halls;
                                             
            //Act

            //Assert
            //There are 2 halls in the test database
             Assert.AreEqual(2, await halls.CountAsync());

            /*
            IndexModel indexModel = new IndexModel(context);

            await indexModel.OnGetAsync();
            var result = indexModel.Hall;

            Assert.AreEqual(2, result.Count);*/
        }

        [Test, Order(1)]
        [TestCase(2)]
        public async Task GetHallById(int id)
        {
            //Try to get Hall with id nr. 2
            Hall hall = await context.Halls.FirstOrDefaultAsync(x => x.Id == id);       

            Assert.AreEqual("Movie Hall 2", hall.Name);            
        }
    }
}
