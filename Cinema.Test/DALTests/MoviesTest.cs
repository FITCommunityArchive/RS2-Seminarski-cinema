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
        public async Task GetMovieById(int id)
        {
            //Try to get Movie with id
            Movie movie = await unit.Movies.GetAsync(id);

            Assert.AreEqual("Black Widow", movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingMovie(int id)
        {
            //Try to get non-existing Movie
            var ex = Assert.Throws<ArgumentException>(() => unit.Movies.GetAsync(id));

            Assert.AreEqual(ex.Message, $"There is no object with id: {id} in the database");
        }

        [Test, Order(4)]
        public async Task InsertMovie()
        {
            Movie movie = new Movie
            {
                Title = "New Movie"
            };

            await unit.Movies.InsertAsync(movie);
            await unit.SaveAsync();

            //Id of the new movie will be 13
            Movie newMovie = await unit.Movies.GetAsync(13);

            Assert.AreEqual("New Movie", newMovie.Title);
        }

        [Test, Order(5)]
        public async Task ChangeMovieName()
        {
            //Try to change the movie 
            int id = 2;

            Movie movie = await unit.Movies.GetAsync(id);
            movie.Title = "New Movie";

            await unit.Movies.UpdateAsync(movie, id);
            unit.Save();

            Movie newMovie = await unit.Movies.GetAsync(id);

            Assert.AreEqual("New Movie", newMovie.Title); ;
        }

        [Test, Order(6)]
        public async Task DeleteMovie()
        {
            //Try to change the movie 
            int id = 2;

            await unit.Movies.DeleteAsync(id);

            Movie movieAftedDelete = await unit.Movies.GetAsync(id);

            Assert.AreEqual(true, movieAftedDelete.Deleted);
        }
    }
}
