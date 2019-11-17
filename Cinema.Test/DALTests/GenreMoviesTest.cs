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
    class GenreGenreMoviesTest : TestBase
    {
        [Test, Order(1)]
        public void GetAllGenreMovies()
        {
            //Arrange
            DbSet<GenreMovie> genreMovies = context.GenreMovies;

            //Act

            //Assert
            //There are 5 genreMovies in the test database
            Assert.AreEqual(5, genreMovies.Count());
        }

        [Test, Order(2)]
        [TestCase(3)]
        public void GetGenreMovieById(int id)
        {
            //Try to get GenreMovie with id
            GenreMovie genreMovie = context.GenreMovies.FirstOrDefault(x => x.Id == id);

            Assert.AreEqual("Police Academy 4: Citizens on Patrol", genreMovie.Movie.Title);
        }


        [Test, Order(3)]
        [TestCase(100)]
        public void GetNonExistingGenreMovie(int id)
        {
            //Try to get non-existing GenreMovie
            GenreMovie genreMovie = context.GenreMovies.FirstOrDefault(x => x.Id == id);

            Assert.IsNull(genreMovie);
        }

        [Test, Order(4)]
        public void InsertGenreMovie()
        {
            GenreMovie genreMovie = new GenreMovie
            {
                Movie = context.Movies.Find(1),
                Genre = context.Genres.Find(1)
            };

            context.GenreMovies.Add(genreMovie);
            context.SaveChanges();

            //Id of the new genreMovie will be 6
            GenreMovie newGenreMovie = context.GenreMovies.Find(6);

            Assert.AreEqual("Bomb the System", newGenreMovie.Movie.Title);
        }

        [Test, Order(5)]
        public void ChangeGenreMoviesMovie()
        {
            //Try to change the genreMovie 
            int id = 2;

            GenreMovie genreMovie = context.GenreMovies.Find(id);

            Movie newMovie = context.Movies.Find(3);
            genreMovie.Movie = newMovie;

            context.GenreMovies.Update(genreMovie);
            context.SaveChanges();

            GenreMovie newGenreMovie = context.GenreMovies.Find(id);

            Assert.AreEqual("Black Widow", newGenreMovie.Movie.Title); ;
        }

        [Test, Order(6)]
        public void DeleteGenreMovie()
        {
            //Try to change the genreMovie 
            int id = 2;

            GenreMovie genreMovie = context.GenreMovies.Find(id);

            context.GenreMovies.Remove(genreMovie);
            context.SaveChanges();

            GenreMovie genreMovieAfterDelete = context.GenreMovies.FirstOrDefault(x => x.Id == id);
            Assert.IsNull(genreMovieAfterDelete);
        }
    }
}
