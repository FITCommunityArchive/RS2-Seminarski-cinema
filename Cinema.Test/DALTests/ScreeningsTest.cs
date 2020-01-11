using Cinema.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public void GetScreeningById(int id)
        {
            //Try to get Screening with id
            Screening screening = unit.Screenings.Get(id);

            //Id of the Movie the screening is for
            Assert.AreEqual(7, screening.Movie.Id);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingScreening(int id)
        {
            //Try to get non-existing Screening
            var ex = Assert.Throws<ArgumentException>(() => unit.Screenings.Get(id));

            Assert.AreEqual(ex.Message, $"There is no object with id: {id} in the database");
        }

        [Test, Order(4)]
        public void InsertScreening()
        {
            Screening screening = new Screening
            {
                Movie = unit.Movies.Get(1)
            };

            unit.Screenings.Insert(screening);
            unit.Save();

            //Id of the new screening will be 13
            Screening newScreening = unit.Screenings.Get(13);

            Assert.AreEqual("Bomb the System", newScreening.Movie.Title);
        }

        [Test, Order(5)]
        public void ChangeScreeningMovie()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = unit.Screenings.Get(id);

            Movie newMovie = unit.Movies.Get(3);
            screening.Movie = newMovie;

            unit.Screenings.Update(screening, id);
            unit.Save();

            Screening newScreening = unit.Screenings.Get(id);

            Assert.AreEqual("Black Widow", newScreening.Movie.Title);
        }

        [Test, Order(6)]
        public void DeleteScreening()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = unit.Screenings.Get(id);

            unit.Screenings.Delete(screening);

            Screening screeningAfterDelete = unit.Screenings.Get(id);
            Assert.AreEqual(true, screeningAfterDelete.Deleted);
        }
    }
}
