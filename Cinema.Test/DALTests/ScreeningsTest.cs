using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Test.DALTests
{
    [TestFixture]
    class ScreeningsTest : TestBase
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
        [TestCase(3)]
        public async Task GetScreeningById(int id)
        {
            //Try to get Screening with id
            Screening screening = await unit.Screenings.GetAsync(id);

            //Id of the Movie the screening is for
            Assert.AreEqual(7, screening.Movie.Id);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingScreening(int id)
        {
            //Try to get non-existing Screening
            var ex = Assert.Throws<ArgumentException>(() => unit.Screenings.GetAsync(id));

            Assert.AreEqual(ex.Message, $"There is no object with id: {id} in the database");
        }

        [Test, Order(4)]
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
        public async Task DeleteScreening()
        {
            //Try to change the screening 
            int id = 2;

            await unit.Screenings.DeleteAsync(id);

            Screening screeningAfterDelete = await unit.Screenings.GetAsync(id);
            Assert.AreEqual(true, screeningAfterDelete.Deleted);
        }
    }
}
