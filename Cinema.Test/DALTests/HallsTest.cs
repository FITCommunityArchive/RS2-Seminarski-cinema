using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Seed.CollectMethods;
using Cinema.Services.Exceptions;
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
    public class HallsTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllHalls()
        {
            //Arrange
            int hallsCount = unit.Halls.Get().Count();
                                             
            //Act

            //Assert
            //There are 2 halls in the test database
             Assert.AreEqual(2, hallsCount);

            /*
            IndexModel indexModel = new IndexModel(context);

            await indexModel.OnGetAsync();
            var result = indexModel.Hall;

            Assert.AreEqual(2, result.Count);*/
        }

        [Test, Order(2)]
        public async Task InsertHall()
        {
            Hall hall = new Hall
            {
                Name = "New Hall"
            };

            await unit.Halls.InsertAsync(hall);
            unit.Save();

            //id of the new hall will be 3
            Hall newHall = await unit.Halls.GetAsync(3);

            Assert.AreEqual("New Hall", newHall.Name);
        }

        [Test, Order(3)]
        [TestCase(5)]
        public async Task GetNonExistingHall(int id)
        {
            //Try to get non-existing Hall

            var result = await unit.Halls.GetAsync(id);

            Assert.IsNull(result);
        }

        [Test, Order(4)]
        [TestCase(3)]
        public async Task GetHallById(int id)
        {
            //Try to get Hall with id
            Hall hall = await unit.Halls.GetAsync(id);

            Assert.AreEqual("New Hall", hall.Name);
        }

        [Test, Order(5)]
        public async Task ChangeHallName()
        {
            //Try to change the hall 
            int id = 2;

            Hall hall = await unit.Halls.GetAsync(id);
            hall.Name = "New Hall";

            await unit.Halls.UpdateAsync(hall, id);
            unit.Save();

            Assert.AreEqual("New Hall", hall.Name);
        }

        [Test, Order(6)]
        public async Task DeleteHall()
        {
            //Try to delete the hall 
            int id = 2;

            Hall hall = await unit.Halls.GetAsync(id);

            var ex = Assert.ThrowsAsync<DependentObjectsPresentException>(async () => await unit.Halls.DeleteAsync(hall.Id));
        }

        [Test, Order(7)]
        public async Task DeleteHallWithoutChildObjects()
        {
            Hall hall = new Hall
            {
                Name = "New Hall"
            };

            await unit.Halls.InsertAsync(hall);
            await unit.SaveAsync();
            int hallId = hall.Id;

            await unit.Halls.DeleteAsync(hallId);
            await unit.SaveAsync();

            Hall deletedHall = await unit.Halls.GetAsync(hallId);
            Assert.True(deletedHall.Deleted);
        }
    }
}
