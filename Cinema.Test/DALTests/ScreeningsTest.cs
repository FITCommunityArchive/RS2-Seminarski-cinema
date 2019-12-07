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
            DbSet<Screening> screenings = context.Screenings;

            //Act

            //Assert
            //There are 42 screenings in the test database
            Assert.AreEqual(42, screenings.Count());
        }

        [Test, Order(2)]
        [TestCase(3)]
        public void GetScreeningById(int id)
        {
            //Try to get Screening with id
            Screening screening = context.Screenings.FirstOrDefault(x => x.Id == id);

            //Id of the Movie the screening is for
            Assert.AreEqual(7, screening.Movie.Id);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingScreening(int id)
        {
            //Try to get non-existing Screening
            Screening screening = context.Screenings.FirstOrDefault(x => x.Id == id);

            Assert.IsNull(screening);
        }

        [Test, Order(4)]
        public void InsertScreening()
        {
            Screening screening = new Screening
            {
                Movie = context.Movies.Find(1)
            };

            context.Screenings.Add(screening);
            context.SaveChanges();

            //Id of the new screening will be 13
            Screening newScreening = context.Screenings.Find(13);

            Assert.AreEqual("Bomb the System", newScreening.Movie.Title);
        }

        [Test, Order(5)]
        public void ChangeScreeningMovie()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = context.Screenings.Find(id);

            Movie newMovie = context.Movies.Find(3);
            screening.Movie = newMovie;

            context.Screenings.Update(screening);
            context.SaveChanges();

            Screening newScreening = context.Screenings.Find(id);

            Assert.AreEqual("Black Widow", newScreening.Movie.Title);
        }

        [Test, Order(6)]
        public void DeleteScreening()
        {
            //Try to change the screening 
            int id = 2;

            Screening screening = context.Screenings.Find(id);

            context.Screenings.Remove(screening);
            context.SaveChanges();

            Screening screeningAfterDelete = context.Screenings.FirstOrDefault(x => x.Id == id);
            Assert.IsNull(screeningAfterDelete);
        }
    }
}
