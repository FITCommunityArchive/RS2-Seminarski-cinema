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
    public class ScreeningsTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllScreenings()
        {
            //Arrange
            int screeningsCount = unit.Screenings.Get().Count();

            //Act

            //Assert
            //There are 42 screenings in the test database
            Assert.AreEqual(42, screeningsCount);
        }

        [Test, Order(2)]
        public async Task InsertScreening()
        {
            Screening screening = new Screening
            {
                Movie = await unit.Movies.GetAsync(1)
            };

            await unit.Screenings.InsertAsync(screening);
            unit.Save();

            //Id of the new screening will be 13
            Screening newScreening = await unit.Screenings.GetAsync(13);

            Assert.AreEqual("Bomb the System", newScreening.Movie.Title);
        }

        [Test, Order(3)]
        [TestCase(13)]
        public async Task GetScreeningById(int id)
        {
            //Try to get Screening with id
            Screening screening = await unit.Screenings.GetAsync(id);

            //Id of the Movie the screening is for
            Assert.AreEqual(1, screening.Movie.Id);
        }

        [Test, Order(4)]
        [TestCase(100)]
        public async Task GetNonExistingScreening(int id)
        {
            //Try to get non-existing Screening
            Screening screening = await unit.Screenings.GetAsync(id);

            Assert.IsNull(screening);
        }

        [Test, Order(5)]
        public async Task ChangeScreeningMovie()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = await unit.Screenings.GetAsync(id);

            Movie newMovie = await unit.Movies.GetAsync(3);
            screening.Movie = newMovie;

            await unit.Screenings.UpdateAsync(screening, id);
            unit.Save();

            Screening newScreening = await unit.Screenings.GetAsync(id);

            Assert.AreEqual("Black Widow", newScreening.Movie.Title);
        }

        [Test, Order(6)]
        public void DeleteScreeningWithChildObjects()
        {
            //Try to delete the screening 
            int id = 2;

            var ex = Assert.ThrowsAsync<DependentObjectsPresentException>(async () => await unit.Screenings.DeleteAsync(id));
        }

        [Test, Order(7)]
        public async Task DeleteScreeningWithoutChildObjects()
        {
            Screening screening = new Screening();

            await unit.Screenings.InsertAsync(screening);
            await unit.SaveAsync();
            int screeningId = screening.Id;

            await unit.Screenings.DeleteAsync(screeningId);
            await unit.SaveAsync();

            Screening deletedScreening = await unit.Screenings.GetAsync(screeningId);

            Assert.True(deletedScreening.Deleted);
        }
    }
}
