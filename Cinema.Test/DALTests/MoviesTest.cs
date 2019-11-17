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
            DbSet<Movie> movies = context.Movies;

            //Act

            //Assert
            //There are 12 movies in the test database
            Assert.AreEqual(12, movies.Count());
        }

        [Test, Order(2)]
        [TestCase(3)]
        public void GetMovieById(int id)
        {
            //Try to get Movie with id
            Movie movie = context.Movies.FirstOrDefault(x => x.Id == id);

            Assert.AreEqual("Black Widow", movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingMovie(int id)
        {
            //Try to get non-existing Movie
            Movie movie = context.Movies.FirstOrDefault(x => x.Id == id);

            Assert.IsNull(movie);
        }

        [Test, Order(4)]
        public void InsertMovie()
        {
            Movie movie = new Movie
            {
                Title = "New Movie"
            };

            context.Movies.Add(movie);
            context.SaveChanges();

            //Id of the new movie will be 13
            Movie newMovie = context.Movies.Find(13);

            Assert.AreEqual("New Movie", newMovie.Title);
        }

        [Test, Order(5)]
        public void ChangeMovieName()
        {
            //Try to change the movie 
            int id = 2;

            Movie movie = context.Movies.Find(id);
            movie.Title = "New Movie";

            context.Movies.Update(movie);
            context.SaveChanges();

            Movie newMovie = context.Movies.Find(id);

            Assert.AreEqual("New Movie", newMovie.Title); ;
        }

        [Test, Order(6)]
        public void DeleteMovie()
        {
            //Try to change the movie 
            int id = 2;

            Movie movie = context.Movies.Find(id);

            context.Movies.Remove(movie);
            context.SaveChanges();

            Movie movieAfterDelete = context.Movies.FirstOrDefault(x => x.Id == id);
            Assert.IsNull(movieAfterDelete);
        }
    }
}
