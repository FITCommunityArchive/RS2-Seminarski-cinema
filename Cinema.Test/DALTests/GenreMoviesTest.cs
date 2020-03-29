using Cinema.DAL.Data;
using Cinema.Domain.Entities;
using Cinema.Seed.CollectMethods;
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
    class GenreMoviesTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllGenreMovies()
        {
            //Arrange
            int genreMoviesCount = unit.GenreMovies.Get().Count();

            //Act

            //Assert
            //There are 5 genreMovies in the test database
            Assert.AreEqual(5, genreMoviesCount);
        }

        [Test, Order(2)]
        [TestCase(3)]
        public async Task GetGenreMovieById(int id)
        {
            //Try to get GenreMovie with id
            GenreMovie genreMovie = await unit.GenreMovies.GetAsync(id);

            Assert.AreEqual("Police Academy 4: Citizens on Patrol", genreMovie.Movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public async Task GetNonExistingGenreMovie(int id)
        {
            //Try to get non-existing GenreMovie
            var result = await unit.GenreMovies.GetAsync(id);

            Assert.IsNull(result);
        }

        [Test, Order(4)]
        public async Task InsertGenreMovie()
        {
            GenreMovie genreMovie = new GenreMovie
            {
                Movie = await unit.Movies.GetAsync(1),
                Genre = await unit.Genres.GetAsync(1)
            };

            await unit.GenreMovies.InsertAsync(genreMovie);
            unit.Save();

            //Id of the new genreMovie will be 6
            GenreMovie newGenreMovie = await unit.GenreMovies.GetAsync(6);

            Assert.NotNull(newGenreMovie);
            Assert.NotNull(newGenreMovie.Movie.Title);
            Assert.NotNull(newGenreMovie.Genre.Name);
        }

        [Test, Order(5)]
        public async Task ChangeGenreMoviesMovie()
        {
            //Try to change the genreMovie 
            int id = 2;

            GenreMovie genreMovie = await unit.GenreMovies.GetAsync(id);

            Movie newMovie = await unit.Movies.GetAsync(3);
            genreMovie.Movie = newMovie;

            await unit.GenreMovies.UpdateAsync(genreMovie, id);
            unit.Save();

            GenreMovie newGenreMovie = await unit.GenreMovies.GetAsync(id);

            Assert.AreEqual("Black Widow", newGenreMovie.Movie.Title); ;
        }

        [Test, Order(6)]
        public async Task DeleteGenreMovie()
        {            
            int id = 2;

            await unit.GenreMovies.DeleteAsync(id);

            int numberOfChanges = unit.Save();
            Assert.AreEqual(1, numberOfChanges);
        }
    }
}
