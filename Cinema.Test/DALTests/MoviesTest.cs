using Cinema.Domain.Entities;
using Cinema.Services.Exceptions;
using NUnit.Framework;
using System.Linq;
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

        [Test, Order(3)]
        [TestCase(13)]
        public async Task GetMovieById(int id)
        {
            //Try to get Movie with id
            Movie movie = await unit.Movies.GetAsync(id);

            Assert.AreEqual("New Movie", movie.Title);
        }

        [Test, Order(4)]
        [TestCase(100)]
        public async Task GetNonExistingMovie(int id)
        {
            //Try to get non-existing Movie
            Movie movie = await unit.Movies.GetAsync(id);

            Assert.IsNull(movie);
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
        public void DeleteMovieWithChildObjects()
        {
            //Try to delete the movie 
            int id = 2;

            var ex = Assert.ThrowsAsync<DependentObjectsPresentException>(async () => await unit.Movies.DeleteAsync(id));
        }

        [Test, Order(7)]
        public async Task DeleteMovieWithoutChildObjects()
        {
            Movie movie = new Movie
            {
                Title = "New Hall"
            };

            await unit.Movies.InsertAsync(movie);
            await unit.SaveAsync();
            int movieId = movie.Id;

            await unit.Movies.DeleteAsync(movieId);
            await unit.SaveAsync();

            Movie deletedMovie = await unit.Movies.GetAsync(movieId);

            Assert.True(deletedMovie.Deleted);
        }
    }
}
