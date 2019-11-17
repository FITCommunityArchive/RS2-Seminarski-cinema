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

        [Test, Order(2)]
        [TestCase(2)]
        public async Task GetHallById(int id)
        {
            //Try to get Hall with id
            Hall hall = await context.Halls.FirstOrDefaultAsync(x => x.Id == id);       

            Assert.AreEqual("Movie Hall 2", hall.Name);            
        }


        [Test, Order(3)]
        [TestCase(5)]
        public async Task GetNonExistingHall(int id)
        {
            //Try to get non-existing Hall
            Hall hall = await context.Halls.FirstOrDefaultAsync(x => x.Id == id);

            Assert.IsNull(hall);
        }

        [Test, Order(4)]
        public void InsertHall()
        {
            Hall hall = new Hall
            {
                Name = "New Hall"
            };

            context.Halls.Add(hall);
            context.SaveChanges();

            Assert.AreEqual("New Hall", hall.Name);
        }

        [Test, Order(5)]
        public void ChangeHallName()
        {
            //Try to change the hall 
            int id = 2;

            Hall hall = context.Halls.Find(id);
            hall.Name = "New Hall";

            context.Halls.Update(hall);
            context.SaveChanges();

            Assert.AreEqual("New Hall", hall.Name);
        }

        [Test, Order(6)]
        public async Task DeleteHall()
        {
            //Try to change the hall 
            int id = 2;

            Hall hall = context.Halls.Find(id);

            context.Halls.Remove(hall);
            context.SaveChanges();

            Hall hallAfterDelete = await context.Halls.FirstOrDefaultAsync(x => x.Id == id);            
            Assert.IsNull(hallAfterDelete);
        }
    }
}
