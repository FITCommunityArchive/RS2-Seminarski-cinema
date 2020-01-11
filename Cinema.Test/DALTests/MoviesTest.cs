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
    class MoviesTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllMovies()
        {
            //Arrange
            int moviesCount = unit.Movies.Get().Count();

            //Act

            //Assert
            //There are 12 movies in the test database
            Assert.AreEqual(12, moviesCount);
        }

        [Test, Order(2)]
        [TestCase(3)]
        public void GetMovieById(int id)
        {
            //Try to get Movie with id
            Movie movie = unit.Movies.Get(id);

            Assert.AreEqual("Black Widow", movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingMovie(int id)
        {
            //Try to get non-existing Movie
            Movie movie = unit.Movies.Get(id);

            Assert.IsNull(movie);
        }

        [Test, Order(4)]
        public void InsertMovie()
        {
            Movie movie = new Movie
            {
                Title = "New Movie"
            };

            unit.Movies.Insert(movie);
            unit.Save();

            //Id of the new movie will be 13
            Movie newMovie = unit.Movies.Get(13);

            Assert.AreEqual("New Movie", newMovie.Title);
        }

        [Test, Order(5)]
        public void ChangeMovieName()
        {
            //Try to change the movie 
            int id = 2;

            Movie movie = unit.Movies.Get(id);
            movie.Title = "New Movie";

            unit.Movies.Update(movie, id);
            unit.Save();

            Movie newMovie = unit.Movies.Get(id);

            Assert.AreEqual("New Movie", newMovie.Title); ;
        }

        [Test, Order(6)]
        public void DeleteMovie()
        {
            //Try to change the movie 
            int id = 2;

            Movie movie = unit.Movies.Get(id);

            unit.Movies.Delete(movie);
            unit.Save();

            Movie movieAfterDelete = unit.Movies.Get(id);
            Assert.IsNull(movieAfterDelete);
        }
    }
}
