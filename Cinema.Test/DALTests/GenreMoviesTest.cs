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
        public void GetGenreMovieById(int id)
        {
            //Try to get GenreMovie with id
            GenreMovie genreMovie = unit.GenreMovies.Get(id);

            Assert.AreEqual("Police Academy 4: Citizens on Patrol", genreMovie.Movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingGenreMovie(int id)
        {
            //Try to get non-existing GenreMovie
            var ex = Assert.Throws<ArgumentException>(() => unit.GenreMovies.Get(id));

            Assert.AreEqual(ex.Message, $"There is no object with id: {id} in the database");
        }

        [Test, Order(4)]
        public void InsertGenreMovie()
        {
            GenreMovie genreMovie = new GenreMovie
            {
                Movie = unit.Movies.Get(1),
                Genre = unit.Genres.Get(1)
            };

            unit.GenreMovies.Insert(genreMovie);
            unit.Save();

            //Id of the new genreMovie will be 6
            GenreMovie newGenreMovie = unit.GenreMovies.Get(6);

            Assert.AreEqual("Bomb the System", newGenreMovie.Movie.Title);
        }

        [Test, Order(5)]
        public void ChangeGenreMoviesMovie()
        {
            //Try to change the genreMovie 
            int id = 2;

            GenreMovie genreMovie = unit.GenreMovies.Get(id);

            Movie newMovie = unit.Movies.Get(3);
            genreMovie.Movie = newMovie;

            unit.GenreMovies.Update(genreMovie, id);
            unit.Save();

            GenreMovie newGenreMovie = unit.GenreMovies.Get(id);

            Assert.AreEqual("Black Widow", newGenreMovie.Movie.Title); ;
        }

        [Test, Order(6)]
        public void DeleteGenreMovie()
        {
            //Try to change the genreMovie 
            int id = 2;

            GenreMovie genreMovie = unit.GenreMovies.Get(id);

            unit.GenreMovies.Delete(id);

            int numberOfChanges = unit.Save();
            Assert.AreEqual(1, numberOfChanges);
        }
    }
}
